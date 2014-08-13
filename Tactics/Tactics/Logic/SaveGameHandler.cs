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

            gameInit.getFreeRoamState().setCharacterXPos(50);
            gameInit.getFreeRoamState().setCharacterYPos(50);
            gameInit.getFreeRoamState().setCharacterHeight(2);
            //gameInit.getFreeRoamState().setCurrentRegion(0);
            //gameInit.getFreeRoamState().setCurrentZone(0);
            gameInit.getFreeRoamState().setCharacterFacingDirection(0);
            gameInit.getGameState().setFreeRoamState();

            gameInit.getParty().addPartyMember(gameInit.getCharacterFactory().createCharacter(0, 0));
        }
    }
}
