using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework;

namespace Tactics.Game.Animations
{
    class HumanoidAnimations : Animation
    {

        public HumanoidAnimations()
        {
            spriteSize = new Vector2(24, 34);
            sectionSize = new Vector2(30, 40);

            animations = new List<int>();
            animationOffsets = new List<List<Vector2>>();
            fillAnimations();
        }

        private void fillAnimations()
        {
            // fix the temp list shit
            List<Vector2> tempList = new List<Vector2>();

            // top right
            animations.Add(1);
            tempList.Clear();
            tempList.Add(new Vector2(0, 0));
            animationOffsets.Add(tempList);

            // bottom right
            animations.Add(1);
            tempList.Clear();
            tempList.Add(new Vector2(0, 0));
            animationOffsets.Add(tempList);

            // bottom left
            animations.Add(1);
            tempList.Clear();
            tempList.Add(new Vector2(0, 0));
            animationOffsets.Add(tempList);

            // top left
            animations.Add(1);
            tempList.Clear();
            tempList.Add(new Vector2(0, 0));
            animationOffsets.Add(tempList);

            // walk top right
            animations.Add(6);
            tempList.Clear();
            tempList.Add(new Vector2(0, 0));
            tempList.Add(new Vector2(0, 0));
            tempList.Add(new Vector2(0, 0));
            animationOffsets.Add(tempList);

            // walk bottom right
            animations.Add(6);
            tempList.Clear();
            tempList.Add(new Vector2(0, 0));
            tempList.Add(new Vector2(0, 0));
            tempList.Add(new Vector2(0, 0));
            animationOffsets.Add(tempList);

            // walk bottom left
            animations.Add(6);
            tempList.Clear();
            tempList.Add(new Vector2(0, 0));
            tempList.Add(new Vector2(0, 0));
            tempList.Add(new Vector2(0, 0));
            animationOffsets.Add(tempList);

            // walk top left
            animations.Add(6);
            tempList.Clear();
            tempList.Add(new Vector2(0, 0));
            tempList.Add(new Vector2(0, 0));
            tempList.Add(new Vector2(0, 0));
            animationOffsets.Add(tempList);
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
