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


        public MovementHandler()
        {
        }

        public bool checkMove(GameInit gameInit, KeyHandler keyHandler, ContentHandler content)
        {
            int direction = getGreatestDirection(keyHandler);

            if (direction == 0)
            {
                return true;
            }
            else if (direction == 1)
            {
                return true;
            }
            else if (direction == 2)
            {
                return true;
            }
            else if (direction == 3)
            {
                return true;
            }
            else
            {
                return false;
            }
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
