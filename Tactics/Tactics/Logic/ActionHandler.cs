using System;
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

        private List<Character> interactingCharacters;
        private List<ManipulatableObject> activatingObjects;

        public ActionHandler()
        {
            activating = false;
            interactingCharacters = new List<Character>();
            activatingObjects = new List<ManipulatableObject>();
        }


        public bool checkActions(GameInit gameInit, KeyHandler keyHandler, ContentHandler content)
        {
            if (checkMainAction(gameInit, keyHandler))
            {
                return true;
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
            for (int i = 0; i < activatingObjects.Count; i++)
            {
                ManipulatableObject currentObject = activatingObjects[i];
                Character currentCharacter = interactingCharacters[i];
                currentObject.continueActivation(gameInit, currentCharacter);

                if (currentObject.isFinishedActivating())
                {
                    activatingObjects.RemoveAt(i);
                    interactingCharacters.RemoveAt(i);
                    // finish object activation
                    i--;
                }

                if (activatingObjects.Count == 0 || i == activatingObjects.Count - 1)
                {
                    break;
                }
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
                    //active object
                    return true;
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
    }
}
