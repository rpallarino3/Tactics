using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework;

namespace Tactics.Game.Environment
{
    abstract class Zone
    {
        protected readonly int TILE_SIZE = 20;

        protected Tile[,] tileMap;
        protected int[,] imageMap;
        protected List<Zone> containedZones;

        protected List<int> imageIdentifiers;
        protected List<Vector2> tileLocations;

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

        public List<int> getImageIdentifiers()
        {
            return imageIdentifiers;
        }

        public List<Vector2> getTileLocations()
        {
            return tileLocations;
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

        public void orderTiles()
        {
            int times;
            if (tileHeight >= tileWidth)
            {
                times = tileHeight;
            }
            else
            {
                times = tileWidth;
            }

            for (int i = 0; i < times; i++)
            {
                if (i < tileHeight && i < tileWidth)
                {
                    for (int j = 0; j < i; j++)
                    {
                        imageIdentifiers.Add(imageMap[tileWidth - 1 - i, j]);
                        tileLocations.Add(new Vector2(tileWidth - 1 - i, j));

                        imageIdentifiers.Add(imageMap[tileWidth - 1 - j, i]);
                        tileLocations.Add(new Vector2(tileWidth - 1 - j, i));
                    }

                    imageIdentifiers.Add(imageMap[tileWidth - i - 1, i]);
                    tileLocations.Add(new Vector2(tileWidth - i - 1, i));
                }
                else
                {
                    if (i >= tileWidth)
                    {
                        for (int j = 0; j < tileWidth; j++)
                        {
                            imageIdentifiers.Add(imageMap[tileWidth - 1 - j, i]);
                            tileLocations.Add(new Vector2(tileWidth - 1 - j, i));
                        }
                    }
                    else
                    {
                        for (int j = 0; j < tileHeight; j++)
                        {
                            imageIdentifiers.Add(imageMap[tileWidth - 1 - i, j]);
                            tileLocations.Add(new Vector2(tileWidth - 1 - i, j));
                        }
                    }
                }
            }
        }
    }
}
