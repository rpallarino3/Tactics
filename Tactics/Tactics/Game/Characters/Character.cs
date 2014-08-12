using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Tactics.Game.Characters.CharacterAnimation;

namespace Tactics.Game.Characters
{
    class Character
    {
        private int type;

        private CharacterAnimations characterAnimations;

        public Character(int type)
        {
            this.type = type;
        }

        public int getType()
        {
            return type;
        }
    }
}
