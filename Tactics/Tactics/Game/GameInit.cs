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
            loadGame();
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

        public void loadGame()
        {
            gameState.setFreeRoamState();
            regionFactory.createRegion(0);
            freeRoamState.setCharacterXPos(0);
            freeRoamState.setCharacterYPos(50);
            freeRoamState.setCurrentRegion(0);
            freeRoamState.setCurrentZone(0);
            freeRoamState.setCharacterFacingDirection(0);
        }
    }
}
