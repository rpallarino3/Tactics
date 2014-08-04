using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Tactics.Game;
using Tactics.ContentHandlers;

namespace Tactics.Logic
{
    class SaveGameHandler
    {


        public SaveGameHandler()
        {
        }

        public void saveGame()
        {
        }

        // should find some file and load from it
        public void loadGame(GameInit gameInit, ContentHandler content, TransitionHandler transitionHandler)
        {
            transitionHandler.createRegion(gameInit, content, 0, 0);

            gameInit.getFreeRoamState().setCharacterXPos(90);
            gameInit.getFreeRoamState().setCharacterYPos(90);
            //gameInit.getFreeRoamState().setCurrentRegion(0);
            //gameInit.getFreeRoamState().setCurrentZone(0);
            gameInit.getFreeRoamState().setCharacterFacingDirection(0);
            gameInit.getGameState().setFreeRoamState();
        }
    }
}
