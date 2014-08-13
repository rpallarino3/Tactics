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

        public Character(int type, CharacterAnimations characterAnimations)
        {
            this.type = type;
            this.characterAnimations = characterAnimations;
        }

        public int getType()
        {
            return type;
        }

        public CharacterAnimations getCharacterAnimations()
        {
            return characterAnimations;
        }
    }
}
