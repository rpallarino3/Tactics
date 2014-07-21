using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tactics.Game
{
    class FreeRoamState
    {
        private int currentRegion;
        private int currentZone;
        private int characterXPos;
        private int characterYPos;
        private int characterFacingDirection;

        public FreeRoamState()
        {
        }

        public int getCurrentRegion()
        {
            return currentRegion;
        }

        public void setCurrentRegion(int region)
        {
            currentRegion = region;
        }

        public int getCurrentZone()
        {
            return currentZone;
        }

        public void setCurrentZone(int zone)
        {
            currentZone = zone;
        }

        public int getCharacterXPos()
        {
            return characterXPos;
        }

        public void setCharacterXPos(int pos)
        {
            characterXPos = pos;
        }

        public int getCharacterYPos()
        {
            return characterYPos;
        }

        public void setCharacterYPos(int pos)
        {
            characterYPos = pos;
        }

        public int getCharacterFacingDirection()
        {
            return characterFacingDirection;
        }

        public void setCharacterFacingDirection(int dir)
        {
            characterFacingDirection = dir;
        }
    }
}
