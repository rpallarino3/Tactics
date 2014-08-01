using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework;

namespace Tactics.Game.Animations
{
    class HumanoidAnimations
    {
        private Vector2 spriteStart;
        private Vector2 spriteSize;
        private Vector2 sectionSize;

        private Dictionary<string, Tuple<int, int>> animations;

        public HumanoidAnimations()
        {

            spriteStart = new Vector2(1, 1);
            spriteSize = new Vector2(24, 34);
            sectionSize = new Vector2(30, 40);

            animations = new Dictionary<string, Tuple<int, int>>();
            fillAnimations();
        }

        private void fillAnimations()
        {
            animations.Add("STATIONARYTR", new Tuple<int, int>(0, 1));
            animations.Add("STATIONARYBR", new Tuple<int, int>(1, 1));
            animations.Add("STATIONARYBL", new Tuple<int, int>(2, 1));
            animations.Add("STATIONARYTL", new Tuple<int, int>(3, 1));

            animations.Add("WALKTR", new Tuple<int, int>(4, 3));
            animations.Add("WALKBR", new Tuple<int, int>(5, 3));
            animations.Add("WALKBL", new Tuple<int, int>(6, 3));
            animations.Add("WALKTL", new Tuple<int, int>(7, 3));

        }

        public Vector2 getSpriteStart()
        {
            return spriteStart;
        }

        public Vector2 getSpriteSize()
        {
            return spriteSize;
        }

        public Vector2 getSectionSize()
        {
            return sectionSize;
        }
    }
}
