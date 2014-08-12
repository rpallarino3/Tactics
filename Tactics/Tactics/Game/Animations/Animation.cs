using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework;

namespace Tactics.Game.Animations
{
    abstract class Animation
    {
        protected Vector2 spriteSize;
        protected Vector2 sectionSize;
        protected List<int> animations;
        protected List<List<Vector2>> animationOffsets;

        public Vector2 getSpriteSize()
        {
            return spriteSize;
        }

        public Vector2 getSectionSize()
        {
            return sectionSize;
        }

        public List<int> getAnimations()
        {
            return animations;
        }

        public List<List<Vector2>> getAnimationOffsets()
        {
            return animationOffsets;
        }
    }
}
