using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Tactics.Game.Characters;
using Tactics.Game.Environment.ManipulatableObjects;

using Microsoft.Xna.Framework;

namespace Tactics.Game.Environment
{
    abstract class Zone
    {
        protected readonly int TILE_SIZE = 20;

        protected Tile[,] tileMap;
        protected int[,] imageMap;
        protected List<Zone> containedZones;
        protected TrafficMap trafficMap;

        protected List<int> imageIdentifiers;
        protected List<Vector2> tileLocations;
        protected List<Tile> orderedTiles;

        protected int tileHeight;
        protected int tileWidth;

        protected List<ManipulatableObject> objectList;

        public void initializeObjects()
        {
            for (int i = 0; i < objectList.Count; i++)
            {
                objectList[i].initialize();
            }
        }

        public List<ManipulatableObject> getObjectList()
        {
            return objectList;
        }

        public TrafficMap getTrafficMap()
        {
            return trafficMap;
        }

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

        public List<Tile> getOrderedTiles()
        {
            return orderedTiles;
        }
        
        public void addObject(ManipulatableObject obj, int x, int y)
        {
            trafficMap.getObjectBooleanMap()[x, y] = true;
            trafficMap.getObjectMap()[x, y] = obj;
            objectList.Add(obj);
        }

        public void addCharacter(Character character, int x, int y)
        {
            trafficMap.getCharacterBooleanMap()[x, y] = true;
            trafficMap.getCharacterMap()[x, y] = character;
        }

        public void clearObject(int x, int y)
        {
            trafficMap.getObjectBooleanMap()[x, y] = false;
        }

        public void clearCharacter(int x, int y)
        {
            trafficMap.getCharacterBooleanMap()[x, y] = false;
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
                    tileMap[i, j].flatten();
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

        public void insertBump(int x, int y, int width, int height, int walkingHeight)
        {
            createTileLevel(x + 1, y + 1, width - 2, height - 2, walkingHeight);

            for (int i = x + 1; i < x + width - 1; i++)
            {
                tileMap[i, y].setWalkingHeight(walkingHeight);
                tileMap[i, y].slope(2);
                tileMap[i, y + height - 1].setWalkingHeight(walkingHeight);
                tileMap[i, y + height - 1].slope(0);
            }

            for (int i = y + 1; i < y + height - 1; i++)
            {
                tileMap[x, i].setWalkingHeight(walkingHeight);
                tileMap[x, i].slope(1);
                tileMap[x + width - 1, i].setWalkingHeight(walkingHeight);
                tileMap[x + width - 1, i].slope(3);
            }

            tileMap[x, y].setWalkingHeight(walkingHeight);
            tileMap[x, y].slope(6);
            tileMap[x, y + height - 1].setWalkingHeight(walkingHeight);
            tileMap[x, y + height - 1].slope(4);
            tileMap[x + width - 1, y + height - 1].setWalkingHeight(walkingHeight);
            tileMap[x + width - 1, y + height - 1].slope(7);
            tileMap[x + width - 1, y].setWalkingHeight(walkingHeight);
            tileMap[x + width - 1, y].slope(5);
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
                        orderedTiles.Add(tileMap[tileWidth - 1 - i, j]);
                        //Console.WriteLine("X: " + (tileWidth - 1 - i) + " Y: " + j);

                        imageIdentifiers.Add(imageMap[tileWidth - 1 - j, i]);
                        tileLocations.Add(new Vector2(tileWidth - 1 - j, i));
                        orderedTiles.Add(tileMap[tileWidth - 1 - j, i]);
                        //Console.WriteLine("X: " + (tileWidth - 1 - j) + " Y: " + i);
                    }

                    imageIdentifiers.Add(imageMap[tileWidth - i - 1, i]);
                    tileLocations.Add(new Vector2(tileWidth - i - 1, i));
                    orderedTiles.Add(tileMap[tileWidth - i - 1, i]);
                    //Console.WriteLine("X: " + (tileWidth - 1 - i) + " Y: " + i);
                }
                else
                {
                    if (i >= tileWidth)
                    {
                        for (int j = 0; j < tileWidth; j++)
                        {
                            imageIdentifiers.Add(imageMap[tileWidth - 1 - j, i]);
                            tileLocations.Add(new Vector2(tileWidth - 1 - j, i));
                            orderedTiles.Add(tileMap[tileWidth - 1 - j, i]);
                            //Console.WriteLine("X: " + (tileWidth - 1 - j) + " Y: " + i);
                        }
                    }
                    else
                    {
                        for (int j = 0; j < tileHeight; j++)
                        {
                            imageIdentifiers.Add(imageMap[tileWidth - 1 - i, j]);
                            tileLocations.Add(new Vector2(tileWidth - 1 - i, j));
                            orderedTiles.Add(tileMap[tileWidth - 1 - i, j]);
                            //Console.WriteLine("X: " + (tileWidth - 1 - i) + " Y: " + j);
                        }
                    }
                }
            }
        }
    }
}
