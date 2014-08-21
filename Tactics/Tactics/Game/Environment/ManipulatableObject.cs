using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework;

using Tactics.Game.Environment.ManipulatableObjects.Animations;

namespace Tactics.Game.Environment
{
    abstract class ManipulatableObject
    {
        protected int type;
        protected int xLoc;
        protected int yLoc;
        protected ObjectAnimation animation;

        public abstract void activate();

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
    }
}
