﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Tactics.KeyHandlers;
using Tactics.Game;
using Tactics.ContentHandlers;

namespace Tactics.Logic
{
    class LogicHandler
    {
        private SaveGameHandler saveGameHandler;
        private TransitionHandler transitionHandler;
        private MovementHandler movementHandler;

        public LogicHandler()
        {
            saveGameHandler = new SaveGameHandler();
            transitionHandler = new TransitionHandler();
            movementHandler = new MovementHandler();
        }

        public void updateLogic(GameInit gameInit, KeyHandler keyHandler, ContentHandler content)
        {
            if (gameInit.getGameState().getState() == gameInit.getGameState().START_STATE)
            {
                updateStartLogic(gameInit, keyHandler, content);
            }
            else if (gameInit.getGameState().getState() == gameInit.getGameState().FREE_ROAM_STATE)
            {
                updateFreeRoamLogic(gameInit, keyHandler, content);
            }
            else if (gameInit.getGameState().getState() == gameInit.getGameState().BATTLE_STATE)
            {
                updateBattleLogic(gameInit, keyHandler, content);
            }
            else if (gameInit.getGameState().getState() == gameInit.getGameState().PAUSE_STATE)
            {
            }
        }


        private void updateStartLogic(GameInit gameInit, KeyHandler keyHandler, ContentHandler content)
        {
        }

        private void updateFreeRoamLogic(GameInit gameInit, KeyHandler keyHandler, ContentHandler content)
        {
            updateFreeRoamPlayerLogic(gameInit, keyHandler, content);
        }

        private void updateFreeRoamPlayerLogic(GameInit gameInit, KeyHandler keyHandler, ContentHandler content)
        {
            if (!checkActions(gameInit, keyHandler, content))
            {
                if (!checkMove(gameInit, keyHandler, content))
                {
                    int direction = gameInit.getParty().getPartyMembers()[0].getFacingDirection();

                    if (direction == 0)
                    {
                        gameInit.getParty().getPartyMembers()[0].getCharacterAnimations().setNewAnimation(0);
                    }
                    else if (direction == 1)
                    {
                        gameInit.getParty().getPartyMembers()[0].getCharacterAnimations().setNewAnimation(1);
                    }
                    else if (direction == 2)
                    {
                        gameInit.getParty().getPartyMembers()[0].getCharacterAnimations().setNewAnimation(2);
                    }
                    else if (direction == 3)
                    {
                        gameInit.getParty().getPartyMembers()[0].getCharacterAnimations().setNewAnimation(3);
                    }
                }
                else
                {
                    int direction = gameInit.getParty().getPartyMembers()[0].getFacingDirection();

                    if (direction == 0)
                    {
                        gameInit.getParty().getPartyMembers()[0].setXPosition(gameInit.getParty().getPartyMembers()[0].getX() - 1);
                        gameInit.getParty().getPartyMembers()[0].setHeight(gameInit.getFreeRoamState().getCurrentZone().getTileMap()[gameInit.getParty().getPartyMembers()[0].getX(), gameInit.getParty().getPartyMembers()[0].getY()].getWalkingHeight());
                        gameInit.getParty().getPartyMembers()[0].getCharacterAnimations().setNewAnimation(0);
                    }
                    else if (direction == 1)
                    {
                        gameInit.getParty().getPartyMembers()[0].setXPosition(gameInit.getParty().getPartyMembers()[0].getX() + 1);
                        gameInit.getParty().getPartyMembers()[0].setHeight(gameInit.getFreeRoamState().getCurrentZone().getTileMap()[gameInit.getParty().getPartyMembers()[0].getX(), gameInit.getParty().getPartyMembers()[0].getY()].getWalkingHeight());
                        gameInit.getParty().getPartyMembers()[0].getCharacterAnimations().setNewAnimation(1);
                    }
                    else if (direction == 2)
                    {
                        gameInit.getParty().getPartyMembers()[0].setYPosition(gameInit.getParty().getPartyMembers()[0].getY() - 1);
                        gameInit.getParty().getPartyMembers()[0].setHeight(gameInit.getFreeRoamState().getCurrentZone().getTileMap()[gameInit.getParty().getPartyMembers()[0].getX(), gameInit.getParty().getPartyMembers()[0].getY()].getWalkingHeight());
                        gameInit.getParty().getPartyMembers()[0].getCharacterAnimations().setNewAnimation(2);
                    }
                    else if (direction == 3)
                    {
                        gameInit.getParty().getPartyMembers()[0].setYPosition(gameInit.getParty().getPartyMembers()[0].getY() + 1);
                        gameInit.getParty().getPartyMembers()[0].setHeight(gameInit.getFreeRoamState().getCurrentZone().getTileMap()[gameInit.getParty().getPartyMembers()[0].getX(), gameInit.getParty().getPartyMembers()[0].getY()].getWalkingHeight());
                        gameInit.getParty().getPartyMembers()[0].getCharacterAnimations().setNewAnimation(3);
                    }
                }
            }
            else
            {
            }
        }

        private bool checkActions(GameInit gameInit, KeyHandler keyHandler, ContentHandler content)
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

        private bool checkMove(GameInit gameInit, KeyHandler keyHandler, ContentHandler content)
        {
            return movementHandler.checkMove(gameInit, keyHandler, content);
        }

        private bool checkMenu(GameInit gameInit, KeyHandler keyHandler, ContentHandler content)
        {
            return true;
        }


        private void updateBattleLogic(GameInit gameInit, KeyHandler keyHandler, ContentHandler content)
        {
        }


        //pass in some save data as well
        public void loadGame(GameInit gameInit, ContentHandler content)
        {
            saveGameHandler.loadGame(gameInit, content, transitionHandler);
        }

    }
}
