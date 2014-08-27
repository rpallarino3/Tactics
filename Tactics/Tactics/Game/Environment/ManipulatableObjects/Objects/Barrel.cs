using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Tactics.Game.Environment.ManipulatableObjects.Animations;
using Tactics.Game.Characters;

namespace Tactics.Game.Environment.ManipulatableObjects.Objects
{
    class Barrel : ManipulatableObject
    {

        public Barrel(int x, int y)
        {
            xLoc = x;
            yLoc = y;
            type = 0;
            animation = new BarrelAnimation();

            finishedActivating = true;
            upInteract = true;
            downInteract = true;
            rightInteract = true;
            leftInteract = true;
        }

        public override void activate(GameInit gameInit, Character interactingCharacter, int activationCode)
        {
        }

        public override void continueActivation(GameInit gameInit, Character interactingCharacter)
        {

        }

        public override void finishActivation(GameInit gameInit)
        {
        }

        public override void initialize()
        {
        }
    }
}
