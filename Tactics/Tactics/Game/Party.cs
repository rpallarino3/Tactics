using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Tactics.Game.Characters;

namespace Tactics.Game
{
    class Party
    {
        private List<Character> partyMembers;


        public Party()
        {
            partyMembers = new List<Character>();
        }

        public List<Character> getPartyMembers()
        {
            return partyMembers;
        }

        public void addPartyMember(Character character)
        {
            partyMembers.Add(character);
        }

        public void swapOrder(int i1, int i2)
        {
            Character temp = partyMembers[i1];
            partyMembers[i1] = partyMembers[i2];
            partyMembers[i2] = temp;
        }
    }
}
