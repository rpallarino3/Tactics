using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Tactics.Game.Environment.ManipulatableObjects.Animations;
using Tactics.Game.Characters;

namespace Tactics.Game.Environment.ManipulatableObjects.Objects
{
    class Door : ManipulatableObject
    {
        private int destination;
        private bool locked;

        public Door(int x, int y, int destination, int side, bool locked)
        {
            
            xLoc = x;
            yLoc = y;
            type = 1;
            animation = new DoorAnimation();

            this.destination = destination;
            this.locked = locked;

            finishedActivation = true;
            upInteract = false;
            downInteract = false;
            rightInteract = false;
            leftInteract = false;

            if (side == 0)
            {
                upInteract = true;
                animation.setNewAnimation(0);
            }
            else if (side == 1)
            {
                downInteract = true;
                animation.setNewAnimation(1);
            }
            else if (side == 2)
            {
                rightInteract = true;
                animation.setNewAnimation(2);
            }
            else if (side == 3)
            {
                leftInteract = true;
                animation.setNewAnimation(3);
            }

        }

        public bool isLocked()
        {
            return locked;
        }

        public int getDestination(int destination)
        {
            return destination;
        }

        public override void activate(GameInit gameInit, Character interactingCharacter)
        {
        }

        public override void continueActivation(GameInit gameInit, Character interactingCharacter)
        {
        }
    }
}
