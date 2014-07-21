using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Tactics.Game.Environment;
using Tactics.Game.Environment.TestArea;

namespace Tactics.Game.ZoneFactories
{
    class TestZoneFactory
    {
        List<Zone> regionZones;


        public TestZoneFactory()
        {
            regionZones = new List<Zone>();
        }

        public void createZones()
        {
            regionZones.Add(new TestZone1(0, 100, 100));
        }

        public List<Zone> getRegionZones()
        {
            return regionZones;
        }
    }
}
