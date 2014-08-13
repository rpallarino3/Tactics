using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Tactics.Game.Animations;
using Tactics.Game.Characters.CharacterAnimation;

namespace Tactics.Game.Characters
{
    class CharacterFactory
    {
        private HumanoidAnimations humAnimations;


        public CharacterFactory()
        {
            humAnimations = new HumanoidAnimations();
        }

        public Character createCharacter(int type, int subtype)
        {
            Character character;

            if (type == 0)
            {
                character = new Character(0, new HumanoidCharacterAnimations(subtype, humAnimations));
                
            }
            else
            {
                character = new Character(0, new HumanoidCharacterAnimations(subtype, humAnimations));
            }

            return character;
        }
    }
}
