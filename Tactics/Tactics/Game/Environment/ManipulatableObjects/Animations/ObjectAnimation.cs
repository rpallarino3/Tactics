using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework;

namespace Tactics.Game.Environment.ManipulatableObjects.Animations
{
    abstract class ObjectAnimation
    {

        protected Vector2 spriteSize;
        protected Vector2 sectionSize;
        protected List<int> animations;
        protected int id;
        protected int currentColumn;
        protected int currentRow;

        public void setNewAnimation(int animation)
        {
            currentColumn = 0;
            currentRow = animation;
        }

        public void advanceAnimation()
        {
            if (currentColumn == animations[currentRow] - 1)
            {
                currentColumn = 0;
            }
            else
            {
                currentColumn++;
            }
        }
    }
}
