using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework;

namespace Tactics.Game.Environment.Zones.TestArea
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
            orderedTiles = new List<Tile>();
            trafficMap = new TrafficMap(tileWidth, tileHeight);
            fillZoneMap();
        }

        private void fillZoneMap()
        {
            fillImageMap();
            fillTileMap();
            createTileLevel(0, 0, 50, 100, 1);
            fillImageRectangle(0, 0, 50, 100, 1);
            createTileLevel(50, 50, 50, 50, 2);
            fillImageRectangle(50, 50, 50, 50, 2);
            createTileLevel(90, 90, 10, 10, 10);
            insertBump(10, 10, 10, 10, 2);
            insertBump(11, 11, 8, 8, 3);
            createTileLevel(14, 14, 2, 2, 4);
            createTileLevel(14, 44, 2, 2, 0);
        }
    }
}
