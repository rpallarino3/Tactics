﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Tactics.KeyHandlers;
using Tactics.Game;
using Tactics.ContentHandlers;
using Tactics.Game.Environment.ManipulatableObjects;
using Tactics.Game.Characters;

namespace Tactics.Logic
{
    class ActionHandler
    {
        private bool activating;
        private bool transitionReady;
        private ManipulatableObject transitioningObject;

        private List<Character> interactingCharacters;
        private List<ManipulatableObject> activatingObjects;
        private List<ManipulatableObject> finishedObjects;

        public ActionHandler()
        {
            activating = false;
            interactingCharacters = new List<Character>();
            activatingObjects = new List<ManipulatableObject>();
            finishedObjects = new List<ManipulatableObject>();
        }


        public bool checkActions(GameInit gameInit, KeyHandler keyHandler, ContentHandler content)
        {
            if (keyHandler.isActionReady())
            {
                if (checkMainAction(gameInit, keyHandler))
                {
                    return true;
                }
            }

            if (keyHandler.isBackReady())
            {
                return true;
            }

            if (keyHandler.isM1Ready())
            {
                return true;
            }

            if (keyHandler.isM2Ready())
            {
                return true;
            }
            return false;
        }

        public void continueActivation(GameInit gameInit)
        {
            finishedObjects.Clear();
            for (int i = 0; i < activatingObjects.Count; i++)
            {
                ManipulatableObject currentObject = activatingObjects[i];
                Character currentCharacter = interactingCharacters[i];

                if (currentObject.isFinishedActivating())
                {
                    activatingObjects.RemoveAt(i);
                    interactingCharacters.RemoveAt(i);
                    finishedObjects.Add(currentObject);
                    i--;
                }
                else
                {
                    currentObject.continueActivation(gameInit, currentCharacter);
                }

                if (activatingObjects.Count == 0 || i == activatingObjects.Count - 1)
                {
                    break;
                }
            }

            finishActivation(gameInit);
        }

        public void finishActivation(GameInit gameInit)
        {
            for (int i = 0; i < finishedObjects.Count; i++)
            {
                finishedObjects[i].finishActivation(gameInit);
                if (finishedObjects[i].isTransitionReady())
                {
                    transitionReady = true;
                    transitioningObject = finishedObjects[i];
                }

                // set chat window stuff here
            }

            if (activatingObjects.Count == 0)
            {
                activating = false;
            }
        }

        private bool checkMainAction(GameInit gameInit, KeyHandler keyHandler)
        {
            int direction = gameInit.getParty().getPartyMembers()[0].getFacingDirection();

            if (direction == 0)
            {
                int targetX = gameInit.getParty().getPartyMembers()[0].getX() - 1;
                int targetY = gameInit.getParty().getPartyMembers()[0].getY();

                if (targetX < 0)
                {
                    return false;
                }
                else
                {
                    checkForInteract(gameInit, targetX, targetY);
                }
            }
            else if (direction == 1)
            {
                int targetX = gameInit.getParty().getPartyMembers()[0].getX() + 1;
                int targetY = gameInit.getParty().getPartyMembers()[0].getY();

                if (targetX >= gameInit.getFreeRoamState().getCurrentZone().getTileWidth())
                {
                    return false;
                }
                else
                {
                    checkForInteract(gameInit, targetX, targetY);
                }
            }
            else if (direction == 2)
            {
                int targetX = gameInit.getParty().getPartyMembers()[0].getX();
                int targetY = gameInit.getParty().getPartyMembers()[0].getY() - 1;

                if (targetY < 0)
                {
                    return false;
                }
                else
                {
                    checkForInteract(gameInit, targetX, targetY);
                }
            }
            else if (direction == 3)
            {
                int targetX = gameInit.getParty().getPartyMembers()[0].getX();
                int targetY = gameInit.getParty().getPartyMembers()[0].getY() + 1;

                if (targetY >= gameInit.getFreeRoamState().getCurrentZone().getTileHeight())
                {
                    return false;
                }
                else
                {
                    checkForInteract(gameInit, targetX, targetY);
                }
            }
            else
            {
                return false;
            }
            return false;
        }

        private bool checkForInteract(GameInit gameInit, int targetX, int targetY)
        {
            if (gameInit.getFreeRoamState().getCurrentZone().getTrafficMap().getCharacterBooleanMap()[targetX, targetY])
            {
                // talk to character
                return true;
            }
            else
            {
                if (gameInit.getFreeRoamState().getCurrentZone().getTrafficMap().getObjectBooleanMap()[targetX, targetY])
                {
                    ManipulatableObject obj = gameInit.getFreeRoamState().getCurrentZone().getTrafficMap().getObjectMap()[targetX, targetY];

                    if (obj.checkForInteract(gameInit.getParty().getPartyMembers()[0].getFacingDirection()))
                    {
                        activatingObjects.Add(obj);
                        interactingCharacters.Add(gameInit.getParty().getPartyMembers()[0]);
                        obj.activate(gameInit, gameInit.getParty().getPartyMembers()[0], 0);
                        activating = true;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
        }


        public bool isActivating()
        {
            return activating;
        }

        public bool isTransitionReady()
        {
            return transitionReady;
        }

        public ManipulatableObject getTransitioningObject()
        {
            return transitioningObject;
        }
    }
}
