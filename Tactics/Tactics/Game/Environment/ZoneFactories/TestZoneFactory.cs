using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Tactics.Game.Environment;
using Tactics.Game.Environment.Zones.TestArea;

namespace Tactics.Game.Environment.ZoneFactories
{
    class TestZoneFactory : ZoneFactory
    {

        public TestZoneFactory()
        {
            regionZones = new List<Zone>();
        }

        public override void createZones()
        {
            regionZones.Add(new TestZone1(0, 100, 100));
            regionZones[0].orderTiles();
            regionZones.Add(new TestZone2(1, 50, 50));
            regionZones[1].orderTiles();
            regionZones.Add(new TestHouse1(2, 10, 10));
            regionZones[2].orderTiles();
        }
    }
}
