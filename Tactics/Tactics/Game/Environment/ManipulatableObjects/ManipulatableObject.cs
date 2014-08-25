using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework;

using Tactics.Game.Environment.ManipulatableObjects.Animations;
using Tactics.Game.Characters;

namespace Tactics.Game.Environment.ManipulatableObjects
{
    abstract class ManipulatableObject
    {
        protected int type;
        protected int xLoc;
        protected int yLoc;
        protected ObjectAnimation animation;
        protected bool finishedActivating;

        protected bool upInteract;
        protected bool downInteract;
        protected bool rightInteract;
        protected bool leftInteract;

        public abstract void activate(GameInit gameInit, Character interactingCharacter, int activationCode);
        public abstract void continueActivation(GameInit gameInit, Character interactingCharacter);

        public int getXLoc()
        {
            return xLoc;
        }

        public int getYLoc()
        {
            return yLoc;
        }

        public ObjectAnimation getObjectAnimation()
        {
            return animation;
        }

        public bool isUpInteract()
        {
            return upInteract;
        }

        public bool isDownInteract()
        {
            return downInteract;
        }

        public bool isRightInteract()
        {
            return rightInteract;
        }

        public bool isLeftInteract()
        {
            return leftInteract;
        }

        public bool isFinishedActivating()
        {
            return finishedActivating;
        }

        public bool checkForInteract(int direction)
        {
            if (direction == 0)
            {
                return downInteract;
            }
            else if (direction == 1)
            {
                return upInteract;
            }
            else if (direction == 2)
            {
                return leftInteract;
            }
            else if (direction == 3)
            {
                return rightInteract;
            }
            else
            {
                return false;
            }
        }
    }
}
