using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tactics.Game
{
    class GameInit
    {

        private GameState gameState;
        private FreeRoamState freeRoamState;
        private RegionFactory regionFactory;

        public GameInit()
        {
            gameState = new GameState();
            freeRoamState = new FreeRoamState();
            regionFactory = new RegionFactory();
        }

        public GameState getGameState()
        {
            return gameState;
        }

        public FreeRoamState getFreeRoamState()
        {
            return freeRoamState;
        }

        public RegionFactory getRegionFactory()
        {
            return regionFactory;
        }

    }
}
