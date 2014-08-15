using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework;
using Tactics.Game;
using Tactics.KeyHandlers;
using Tactics.ContentHandlers;

namespace Tactics.Logic
{
    class MovementHandler
    {
        private readonly int HEIGHT_THRESHOLD = 1;
        private readonly int TURN_THRESHOLD = 5;

        public MovementHandler()
        {
        }

        public bool checkMove(GameInit gameInit, KeyHandler keyHandler, ContentHandler content)
        {
            int direction = getGreatestDirection(keyHandler);

            if (direction == 0)
            {
                if (keyHandler.getUpTime() < TURN_THRESHOLD)
                {
                    gameInit.getParty().getPartyMembers()[0].setFacingDirection(0);
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
                if (keyHandler.getDownTime() < TURN_THRESHOLD)
                {
                    gameInit.getParty().getPartyMembers()[0].setFacingDirection(1);
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
                if (keyHandler.getRightTime() < TURN_THRESHOLD)
                {
                    gameInit.getParty().getPartyMembers()[0].setFacingDirection(2);
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
                if (keyHandler.getLeftTime() < TURN_THRESHOLD)
                {
                    gameInit.getParty().getPartyMembers()[0].setFacingDirection(3);
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
                return greatest;
            }

        }
    }
}
