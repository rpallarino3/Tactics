using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Tactics.Game.Environment.ManipulatableObjects.Animations;

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
        }

        public override void activate()
        {
        }
    }
}
