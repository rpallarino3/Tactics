using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Tactics.Game.Environment.ManipulatableObjects;

using Microsoft.Xna.Framework;

namespace Tactics.Game.Environment.Zones.TestArea
{
    class TestHouse1 : Zone
    {

        public TestHouse1(int zoneNumber, int tileWidth, int tileHeight)
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
        }
    }
}
