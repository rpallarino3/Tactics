using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Tactics.Game.Animations;

namespace Tactics.Game.Characters.CharacterAnimation
{
    class HumanoidCharacterAnimations : CharacterAnimations
    {

        public HumanoidCharacterAnimations(int type, HumanoidAnimations animations)
        {
            this.type = type;
            this.animations = animations;
        }

        public override void advanceAnimation()
        {
            if (currentAnimationColumn < animations.getAnimations().Count - 1)
            {
                currentAnimationColumn++;
            }
            else
            {
                animationFinished = true;
            }
        }

        public override void setNewAnimation(int animation)
        {
            animationFinished = false;
            currentAnimationRow = animation;
            currentAnimationColumn = 0;
        }
    }
}
