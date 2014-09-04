using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Tactics.KeyHandlers;
using Tactics.Game;
using Tactics.ContentHandlers;
using Tactics.Game.Environment.ManipulatableObjects.Objects;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Tactics.Logic
{
    class LogicHandler
    {
        private SaveGameHandler saveGameHandler;
        private TransitionHandler transitionHandler;
        private MovementHandler movementHandler;
        private ObjectHandler objectHandler;
        private ActionHandler actionHandler;

        private Color drawColor;

        public LogicHandler()
        {
            saveGameHandler = new SaveGameHandler();
            transitionHandler = new TransitionHandler();
            movementHandler = new MovementHandler();
            objectHandler = new ObjectHandler();
            actionHandler = new ActionHandler();
            drawColor = Color.White;
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
            //Console.WriteLine("PLAYER X: " + gameInit.getParty().getPartyMembers()[0].getX());
            //Console.WriteLine("PLAYER Y: " + gameInit.getParty().getPartyMembers()[0].getY());
            //Console.WriteLine("HEIGHT: " + gameInit.getParty().getPartyMembers()[0].getHeight());
            if (movementHandler.isMoving())
            {
                movementHandler.updateMove(gameInit);
            }
            else if (transitionHandler.isTransitioning())
            {
                transitionHandler.continueTransition(gameInit);
                drawColor = transitionHandler.getFadeColor();
            }
            else if (actionHandler.isActivating())
            {
                actionHandler.continueActivation(gameInit);

                if (actionHandler.isTransitionReady())
                {
                    transitionHandler.startTransition(gameInit, (Door)actionHandler.getTransitioningObject());
                }
            }
            else if (actionHandler.showBigChat())
            {
            }
            else if (actionHandler.showChatWindow())
            {
                actionHandler.continueChatWindow(gameInit, keyHandler);
            }
            else
            {
                if (!actionHandler.checkActions(gameInit, keyHandler, content))
                {
                    if (!checkMove(gameInit, keyHandler, content))
                    {
                        int x = gameInit.getParty().getPartyMembers()[0].getX();
                        int y = gameInit.getParty().getPartyMembers()[0].getY();
                        int direction = gameInit.getParty().getPartyMembers()[0].getFacingDirection();

                        if (gameInit.getFreeRoamState().getCurrentZone().getTileMap()[x, y].isTransition() && gameInit.getFreeRoamState().getCurrentZone().getTileMap()[x, y].getTransitionDirection() == direction)
                        {
                            gameInit.getParty().getPartyMembers()[0].setFacingDirection(gameInit.getFreeRoamState().getCurrentZone().getTileMap()[x, y].getTransitionDirection());
                            transitionHandler.startTransition(gameInit, gameInit.getFreeRoamState().getCurrentZone().getTileMap()[x, y]);
                        }
                        else
                        {

                            if (direction == 0)
                            {
                                gameInit.getParty().getPartyMembers()[0].getCharacterAnimations().setNewAnimation(0);

                                if (gameInit.getFreeRoamState().getCurrentZone().getTileMap()[x, y].isSloped())
                                {
                                    gameInit.getParty().getPartyMembers()[0].setTileDrawOffset(new Vector2(0, 4));
                                }
                                else
                                {
                                    gameInit.getParty().getPartyMembers()[0].setTileDrawOffset(new Vector2(0, 0));
                                }
                            }
                            else if (direction == 1)
                            {
                                gameInit.getParty().getPartyMembers()[0].getCharacterAnimations().setNewAnimation(1);

                                if (gameInit.getFreeRoamState().getCurrentZone().getTileMap()[x, y].isSloped())
                                {
                                    gameInit.getParty().getPartyMembers()[0].setTileDrawOffset(new Vector2(0, 4));
                                }
                                else
                                {
                                    gameInit.getParty().getPartyMembers()[0].setTileDrawOffset(new Vector2(0, 0));
                                }
                            }
                            else if (direction == 2)
                            {
                                gameInit.getParty().getPartyMembers()[0].getCharacterAnimations().setNewAnimation(2);

                                if (gameInit.getFreeRoamState().getCurrentZone().getTileMap()[x, y].isSloped())
                                {
                                    gameInit.getParty().getPartyMembers()[0].setTileDrawOffset(new Vector2(0, 4));
                                }
                                else
                                {
                                    gameInit.getParty().getPartyMembers()[0].setTileDrawOffset(new Vector2(0, 0));
                                }
                            }
                            else if (direction == 3)
                            {
                                gameInit.getParty().getPartyMembers()[0].getCharacterAnimations().setNewAnimation(3);

                                if (gameInit.getFreeRoamState().getCurrentZone().getTileMap()[x, y].isSloped())
                                {
                                    gameInit.getParty().getPartyMembers()[0].setTileDrawOffset(new Vector2(0, 4));
                                }
                                else
                                {
                                    gameInit.getParty().getPartyMembers()[0].setTileDrawOffset(new Vector2(0, 0));
                                }
                            }
                        }

                    }
                    else
                    {
                        movementHandler.movePlayer(gameInit);
                    }
                }
                else
                {
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

        public Color getDrawColor()
        {
            return drawColor;
        }

    }
}
