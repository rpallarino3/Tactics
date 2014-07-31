using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework;

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
            imageIdentifiers = new List<int>();
            tileLocations = new List<Vector2>();
            containedZones = new List<Zone>();
            tileHeights = new List<int>();
            fillZoneMap();
        }

        private void fillZoneMap()
        {
            fillImageMap();
            fillTileMap();
            createTileLevel(50, 50, 20, 20, 1);
            fillImageRectangle(50, 50, 20, 20, 2);
        }

        private void fillImageTileMap()
        {
            fillImageMap();
        }
    }
}
