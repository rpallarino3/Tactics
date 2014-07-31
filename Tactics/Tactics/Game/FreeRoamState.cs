using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Tactics.Game.Environment;

namespace Tactics.Game
{
    class FreeRoamState
    {
        private int currentRegion;
        private int currentZone;
        private int characterXPos;
        private int characterYPos;
        private int characterFacingDirection;
        private int characterHeight;

        private List<Zone> currentZones;

        public FreeRoamState()
        {
        }

        public void setCurrentZones(List<Zone> newZones)
        {
            currentZones = newZones;
        }

        public List<Zone> getCurrentZones()
        {
            return currentZones;
        }

        public void setCharacterHeight(int height)
        {
            characterHeight = height;
        }

        public int getCharacterHeight()
        {
            return characterHeight;
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
