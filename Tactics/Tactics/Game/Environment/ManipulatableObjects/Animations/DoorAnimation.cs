using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework;

namespace Tactics.Game.Environment.ManipulatableObjects.Animations
{
    class DoorAnimation : ObjectAnimation
    {
        public DoorAnimation()
        {
            id = 1;
            currentColumn = 0;
            currentRow = 0;
            animations = new List<int>();
            spriteSize = new Vector2(40, 40);
            sectionSize = new Vector2(50, 50);
            fillAnimations();
        }

        private void fillAnimations()
        {
            animations.Add(1);
            animations.Add(1);
            animations.Add(1);
            animations.Add(1);
        }
        
    }
}
