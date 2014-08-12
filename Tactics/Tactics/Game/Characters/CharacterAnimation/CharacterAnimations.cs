using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Tactics.Game.Animations;

namespace Tactics.Game.Characters.CharacterAnimation
{
    abstract class CharacterAnimations
    {

        protected int type;
        protected int currentAnimationRow;
        protected int currentAnimationColumn;
        protected Animation animations;
        protected bool animationFinished;

        public abstract void advanceAnimation();
        public abstract void setNewAnimation(int animation);

        public int getType()
        {
            return type;
        }

        public int getCurrentAnimationRow()
        {
            return currentAnimationRow;
        }

        public int getCurrentAnimationColumn()
        {
            return currentAnimationColumn;
        }

        public Animation getAnimations()
        {
            return animations;
        }

        public bool isAnimationFinished()
        {
            return animationFinished;
        }
    }
}
