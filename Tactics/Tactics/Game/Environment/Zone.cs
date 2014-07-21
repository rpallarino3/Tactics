using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tactics.Game.Environment
{
    abstract class Zone
    {
        protected readonly int TILE_SIZE = 20;

        protected Tile[,] tileMap;
        protected int[,] imageMap;
        protected List<Zone> containedZones;

        protected int tileHeight;
        protected int tileWidth;
                
        public Tile[,] getTileMap()
        {
            return tileMap;
        }

        public int[,] getImageMap()
        {
            return imageMap;
        }

        public List<Zone> getContainedZones()
        {
            return containedZones;
        }

        public int getTileWidth()
        {
            return tileWidth;
        }

        public int getTileHeight()
        {
            return tileHeight;
        }

        public int getTileSize()
        {
            return TILE_SIZE;
        }

        public void fillImageMap()
        {
            for (int i = 0; i < tileWidth; i++)
            {
                for (int j = 0; j < tileHeight; j++)
                {
                    imageMap[i, j] = 0;
                }
            }
        }

        public void fillImageRectangle(int x, int y, int width, int height, int imageNumber)
        {
            for (int i = x; i < x + width; i++)
            {
                for (int j = y; j < y + height; j++)
                {
                    imageMap[i, j] = imageNumber;
                }
            }
        }

        public void fillTileMap()
        {
            for (int i = 0; i < tileWidth; i++)
            {
                for (int j = 0; j < tileHeight; j++)
                {
                    tileMap[i, j] = new Tile(false, 0);
                }
            }
        }

        public void createTileLevel(int x, int y, int width, int height, int walkingHeight)
        {

            for (int i = x; i < x + width; i++)
            {
                for (int j = y; j < y + height; j++)
                {
                    tileMap[i, j].setWalkingHeight(walkingHeight);
                }
            }
        }

        public void createSlopedTileLevel(int x, int y, int width, int height, int walkingHeight, int slopedDirection)
        {
            for (int i = x; i < x + width; i++)
            {
                for (int j = y; j < y + height; j++)
                {
                    tileMap[i, j].setWalkingHeight(walkingHeight);
                    tileMap[i, j].slope(slopedDirection);
                }
            }
        }
    }
}
