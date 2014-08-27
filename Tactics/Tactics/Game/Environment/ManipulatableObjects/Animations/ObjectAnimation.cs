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
        protected bool animationFinished;

        public void setNewAnimation(int animation)
        {
            currentColumn = 0;
            currentRow = animation;
            animationFinished = false;
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

                if (currentColumn == animations[currentRow] - 1)
                {
                    animationFinished = true;
                }
            }
        }

        public Vector2 getSpriteSize()
        {
            return spriteSize;
        }

        public Vector2 getSectionSize()
        {
            return sectionSize;
        }

        public int getColumn()
        {
            return currentColumn;
        }

        public int getRow()
        {
            return currentRow;
        }

        public bool isAnimationFinished()
        {
            return animationFinished;
        }

        public int getID()
        {
            return id;
        }
    }
}
