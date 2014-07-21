using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tactics.Game
{
    class GameState
    {
        public readonly int START_STATE = 0;
        public readonly int FREE_ROAM_STATE = 1;
        public readonly int BATTLE_STATE = 2;
        public readonly int PAUSE_STATE = 3;

        private int state;


        public GameState()
        {
            state = START_STATE;
        }

        public void setStartState()
        {
            state = START_STATE;
        }

        public void setFreeRoamState()
        {
            state = FREE_ROAM_STATE;
        }

        public void setBattleState()
        {
            state = BATTLE_STATE;
        }

        public void setPauseMenuState()
        {
            state = PAUSE_STATE;
        }

        public int getState()
        {
            return state;
        }
    }
}
