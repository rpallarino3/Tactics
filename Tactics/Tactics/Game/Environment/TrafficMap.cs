using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Tactics.Game.Characters;

namespace Tactics.Game.Environment
{
    class TrafficMap
    {

        private bool[,] characterBooleanMap;
        private bool[,] objectBooleanMap;
        private Character[,] characterMap;
        private ManipulatableObject[,] objectMap;

        public TrafficMap(int width, int height)
        {
            characterBooleanMap = new bool[width, height];
            objectBooleanMap = new bool[width, height];
            characterMap = new Character[width, height];
            objectMap = new ManipulatableObject[width, height];
            fillMaps(width, height);
        }

        private void fillMaps(int width, int height)
        {
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    characterBooleanMap[i, j] = false;
                    objectBooleanMap[i, j] = false;
                }
            }
        }


        public bool[,] getCharacterBooleanMap()
        {
            return characterBooleanMap;
        }

        public bool[,] getObjectBooleanMap()
        {
            return objectBooleanMap;
        }

        public Character[,] getCharacterMap()
        {
            return characterMap;
        }

        public ManipulatableObject[,] getObjectMap()
        {
            return objectMap;
        }
    }
}
