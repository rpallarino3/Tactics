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
        private Dictionary<int, ZoneFactory> zoneFactories;
        private TestZoneFactory testZoneFactory;


        public RegionFactory()
        {
            zoneFactories = new Dictionary<int, ZoneFactory>();
            testZoneFactory = new TestZoneFactory();
            zoneFactories.Add(0, testZoneFactory);
        }
        
        public List<Zone> getCurrentZones()
        {
            return currentZones;
        }

        public void setCurrentZones(List<Zone> zones)
        {
            currentZones = zones;
        }

        public Dictionary<int, ZoneFactory> getZoneFactories() 
        {
            return zoneFactories;
        }
    }
}
