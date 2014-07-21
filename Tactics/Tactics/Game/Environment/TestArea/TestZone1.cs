using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tactics.Game.Environment.TestArea
{
    class TestZone1 : Zone
    {

        public TestZone1(int zoneNumber, int tileWidth, int tileHeight)
        {
            tileMap = new Tile[tileWidth, tileHeight];
            imageMap = new int[tileWidth, tileHeight];
            this.tileHeight = tileHeight;
            this.tileWidth = tileWidth;

            containedZones = new List<Zone>();
        }

        private void fillZoneMap()
        {
            fillTileMap();
        }

        private void fillImageTileMap()
        {
            fillImageMap();
        }
    }
}
