using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Tactics.Game.Environment;
using Tactics.Game.Environment.TestArea;

namespace Tactics.Game.ZoneFactories
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
        }
    }
}
