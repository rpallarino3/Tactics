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

        public int getCurrentRegion()
        {
            return currentRegion;
        }

        public void setCurrentRegion(int region)
        {
            currentRegion = region;
        }

        public Zone getCurrentZone()
        {
            return currentZones[currentZone];
        }

        public int getCurrentZoneNumber()
        {
            return currentZone;
        }

        public void setCurrentZone(int zone)
        {
            currentZone = zone;
        }
    }
}
