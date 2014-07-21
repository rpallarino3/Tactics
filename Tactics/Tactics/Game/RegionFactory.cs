using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Tactics.Game.ZoneFactories;
using Tactics.Game.Environment;

namespace Tactics.Game
{
    class RegionFactory
    {
        private int currentRegion;
        private List<Zone> currentZones;
        private TestZoneFactory testZoneFactory;


        public RegionFactory()
        {
            testZoneFactory = new TestZoneFactory();
        }

        public void createRegion(int region)
        {
            switch (region)
            {
                case 0:
                    currentRegion = region;
                    testZoneFactory.createZones();
                    currentZones = testZoneFactory.getRegionZones();
                    break;
                case 1:
                    currentRegion = region;
                    break;
                case 2:
                    currentRegion = region;
                    break;
                default:
                    break;
            }
        }

        public List<Zone> getCurrentZones()
        {
            return currentZones;
        }
    }
}
