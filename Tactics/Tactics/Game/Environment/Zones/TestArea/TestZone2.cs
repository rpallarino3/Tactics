using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework;
using Tactics.Game.Environment.ManipulatableObjects.Objects;
using Tactics.Game.Environment.ManipulatableObjects;

namespace Tactics.Game.Environment.Zones.TestArea
{
    class TestZone2 : Zone
    {

        public TestZone2(int zoneNumber, int tileWidth, int tileHeight)
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
            objectList = new List<ManipulatableObject>();
            fillZoneMap();
        }

        private void fillZoneMap()
        {
            fillTileMap();
            fillImageMap();
            createTileLevel(0, 1, 50, 49, 1);
            createTileLevel(0, 10, 10, 2, 2);
            createTileLevel(0, 12, 10, 2, 3);
            createTileLevel(0, 14, 10, 2, 4);
            createTileLevel(0, 16, 10, 2, 5);
            createTileLevel(0, 18, 10, 2, 6);
            createTileLevel(0, 20, 10, 30, 7);
            createTileLevel(10, 30, 4, 6, 8);
            createTileLevel(24, 0, 2, 1, 1);
            insertBump(30, 30, 14, 14, 2);
            insertBump(31, 31, 12, 12, 3);
            insertBump(32, 32, 10, 10, 4);
            insertBump(33, 33, 8, 8, 5);
            fillImageRectangle(0, 1, 50, 49, 1);
            fillImageRectangle(24, 0, 2, 1, 1);
            fillImageRectangle(10, 30, 4, 6, 2);
            addObject(new Barrel(35, 35), 35, 35);
            addObject(new Barrel(35, 35), 37, 35);
            addObject(new Barrel(35, 35), 35, 37);
            addObject(new Barrel(35, 35), 37, 37);
            addObject(new Door(13, 33, 2, new Vector2(0, 0), 1, false, 0, 7, -1), 13, 33);

            tileMap[25, 0].createTransition(false, 0, 2, new Vector2(50, 99));
        }
    }
}
