using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework;
using Tactics.Game;
using Tactics.KeyHandlers;
using Tactics.ContentHandlers;
using Tactics.Game.Environment;

namespace Tactics.Logic
{
    class MovementHandler
    {
        private readonly int HEIGHT_THRESHOLD = 1;
        private readonly int TURN_THRESHOLD = 3;

        private bool moving;
        private int switchThreshold;
        private List<Vector2> movementOffsets;
        private int movementIndex;

        private TileMovementVectors tileMovementVectors;

        public MovementHandler()
        {
            moving = false;
            tileMovementVectors = new TileMovementVectors();
            switchThreshold = 0;
        }

        public bool checkMove(GameInit gameInit, KeyHandler keyHandler, ContentHandler content)
        {
            int direction = getGreatestDirection(keyHandler);

            if (direction == 0)
            {
                gameInit.getParty().getPartyMembers()[0].setFacingDirection(0);
                if (keyHandler.getUpTime() < TURN_THRESHOLD)
                {
                    return false;
                }
                else
                {
                    if (checkHeight(gameInit, -1, 0) && checkAvailability(gameInit, -1, 0))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            else if (direction == 1)
            {
                gameInit.getParty().getPartyMembers()[0].setFacingDirection(1);
                if (keyHandler.getDownTime() < TURN_THRESHOLD)
                {
                    return false;
                }
                else
                {
                    if (checkHeight(gameInit, 1, 0) && checkAvailability(gameInit, 1, 0))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            else if (direction == 2)
            {
                gameInit.getParty().getPartyMembers()[0].setFacingDirection(2);
                if (keyHandler.getRightTime() < TURN_THRESHOLD)
                {
                    return false;
                }
                else
                {
                    if (checkHeight(gameInit, 0, -1) && checkAvailability(gameInit, 0, -1))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            else if (direction == 3)
            {
                gameInit.getParty().getPartyMembers()[0].setFacingDirection(3);
                if (keyHandler.getLeftTime() < TURN_THRESHOLD)
                {
                    return false;
                }
                else
                {
                    if (checkHeight(gameInit, 0, 1) && checkAvailability(gameInit, 0, 1))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            else
            {
                return false;
            }
        }

        private bool checkHeight(GameInit gameInit, int xChange, int yChange)
        {
            int newX = gameInit.getParty().getPartyMembers()[0].getX() + xChange;
            int newY = gameInit.getParty().getPartyMembers()[0].getY() + yChange;

            if (newX >= 0 && newX < gameInit.getFreeRoamState().getCurrentZone().getTileWidth())
            {
                if (newY >= 0 && newY < gameInit.getFreeRoamState().getCurrentZone().getTileHeight())
                {
                    int heightDiff = Math.Abs(gameInit.getParty().getPartyMembers()[0].getHeight() - gameInit.getFreeRoamState().getCurrentZone().getTileMap()[newX, newY].getWalkingHeight());

                    if (heightDiff <= HEIGHT_THRESHOLD)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return false;
        }

        private bool checkAvailability(GameInit gameInit, int xChange, int yChange)
        {
            int newX = gameInit.getParty().getPartyMembers()[0].getX() + xChange;
            int newY = gameInit.getParty().getPartyMembers()[0].getY() + yChange;

            if (newX >= 0 && newX < gameInit.getFreeRoamState().getCurrentZone().getTileWidth())
            {
                if (newY >= 0 && newY < gameInit.getFreeRoamState().getCurrentZone().getTileHeight())
                {
                    bool filledWithObject = gameInit.getFreeRoamState().getCurrentZone().getTrafficMap().getObjectBooleanMap()[newX, newY];
                    bool filledWithChar = gameInit.getFreeRoamState().getCurrentZone().getTrafficMap().getCharacterBooleanMap()[newX, newY];

                    if (filledWithChar || filledWithObject)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private int getGreatestDirection(KeyHandler keyHandler)
        {
            int greatest = 0;
            int time = keyHandler.getUpTime();

            if (keyHandler.getDownTime() > time)
            {
                greatest = 1;
                time = keyHandler.getDownTime();
            }

            if (keyHandler.getRightTime() > time)
            {
                greatest = 2;
                time = keyHandler.getRightTime();
            }

            if (keyHandler.getLeftTime() > time)
            {
                greatest = 3;
                time = keyHandler.getLeftTime();
            }

            if (time == 0)
            {
                return -1;
            }
            else
            {
                //Console.WriteLine("Greatest: " + greatest);
                return greatest;
            }

        }

        public void movePlayer(GameInit gameInit)
        {
            int direction = gameInit.getParty().getPartyMembers()[0].getFacingDirection();

            if (direction == 0)
            {
                int x = gameInit.getParty().getPartyMembers()[0].getX();
                int y = gameInit.getParty().getPartyMembers()[0].getY();

                Tile currentTile = gameInit.getFreeRoamState().getCurrentZone().getTileMap()[x, y];
                Tile destinationTile = gameInit.getFreeRoamState().getCurrentZone().getTileMap()[x - 1, y];

                if (currentTile.isSloped())
                {
                    if (destinationTile.isSloped())
                    {
                    }
                    else
                    {
                        if (destinationTile.getWalkingHeight() > currentTile.getWalkingHeight())
                        {
                        }
                        else if (destinationTile.getWalkingHeight() < currentTile.getWalkingHeight())
                        {
                        }
                        else
                        {
                        }
                    }
                }
                else
                {
                    if (destinationTile.isSloped())
                    {
                    }
                    else
                    {
                        if (destinationTile.getWalkingHeight() > currentTile.getWalkingHeight())
                        {
                            moving = true;
                            movementIndex = 0;
                            gameInit.getParty().getPartyMembers()[0].getCharacterAnimations().setNewAnimation(4);
                            movementOffsets = tileMovementVectors.getVectors(0, "FFH");
                            gameInit.getParty().getPartyMembers()[0].setTileDrawOffset(movementOffsets[movementIndex]);
                            switchThreshold = 5;
                        }
                        else if (destinationTile.getWalkingHeight() < currentTile.getWalkingHeight())
                        {
                            moving = true;
                            movementIndex = 0;
                            gameInit.getParty().getPartyMembers()[0].getCharacterAnimations().setNewAnimation(4);
                            movementOffsets = tileMovementVectors.getVectors(0, "FFL");
                            gameInit.getParty().getPartyMembers()[0].setTileDrawOffset(movementOffsets[movementIndex]);
                            switchThreshold = 5;
                        }
                        else
                        {
                            moving = true;
                            movementIndex = 0;
                            gameInit.getParty().getPartyMembers()[0].getCharacterAnimations().setNewAnimation(4);
                            movementOffsets = tileMovementVectors.getVectors(0, "FFS");
                            gameInit.getParty().getPartyMembers()[0].setTileDrawOffset(movementOffsets[movementIndex]);
                            switchThreshold = 7;
                        }
                    }
                }
            }
            else if (direction == 1)
            {
            }
            else if (direction == 2)
            {
            }
            else if (direction == 3)
            {
            }
        }

        public void updateMove(GameInit gameInit)
        {
            movementIndex++;
            gameInit.getParty().getPartyMembers()[0].getCharacterAnimations().advanceAnimation();
            gameInit.getParty().getPartyMembers()[0].setTileDrawOffset(movementOffsets[movementIndex]);

            if (movementIndex == switchThreshold)
            {
                int direction = gameInit.getParty().getPartyMembers()[0].getFacingDirection();

                if (direction == 0)
                {
                    gameInit.getParty().getPartyMembers()[0].moveUp();
                    int x = gameInit.getParty().getPartyMembers()[0].getX();
                    int y = gameInit.getParty().getPartyMembers()[0].getY();
                    gameInit.getParty().getPartyMembers()[0].setHeight(gameInit.getFreeRoamState().getCurrentZone().getTileMap()[x, y].getWalkingHeight());
                    
                }
                else if (direction == 1)
                {
                    gameInit.getParty().getPartyMembers()[0].moveDown();
                    int x = gameInit.getParty().getPartyMembers()[0].getX();
                    int y = gameInit.getParty().getPartyMembers()[0].getY();
                    gameInit.getParty().getPartyMembers()[0].setHeight(gameInit.getFreeRoamState().getCurrentZone().getTileMap()[x, y].getWalkingHeight());
                }
                else if (direction == 2)
                {
                    gameInit.getParty().getPartyMembers()[0].moveRight();
                    int x = gameInit.getParty().getPartyMembers()[0].getX();
                    int y = gameInit.getParty().getPartyMembers()[0].getY();
                    gameInit.getParty().getPartyMembers()[0].setHeight(gameInit.getFreeRoamState().getCurrentZone().getTileMap()[x, y].getWalkingHeight());
                }
                else if (direction == 3)
                {
                    gameInit.getParty().getPartyMembers()[0].moveLeft();
                    int x = gameInit.getParty().getPartyMembers()[0].getX();
                    int y = gameInit.getParty().getPartyMembers()[0].getY();
                    gameInit.getParty().getPartyMembers()[0].setHeight(gameInit.getFreeRoamState().getCurrentZone().getTileMap()[x, y].getWalkingHeight());
                }
            }

            if (movementIndex == movementOffsets.Count - 1)
            {
                moving = false;
            }
        }

        public bool isMoving()
        {
            return moving;
        }

        public void setMoving(bool move)
        {
            moving = move;
        }

        public int getSwitchThreshold()
        {
            return switchThreshold;
        }

        public void setSwitchTheshold(int threshold)
        {
            switchThreshold = threshold;
        }
    }
}
