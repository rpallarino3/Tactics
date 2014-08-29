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

            gameInit.getParty().addPartyMember(gameInit.getCharacterFactory().createCharacter(0, 0));

            gameInit.getParty().getPartyMembers()[0].setXPosition(50);
            gameInit.getParty().getPartyMembers()[0].setYPosition(50);
            gameInit.getParty().getPartyMembers()[0].setHeight(2);
            gameInit.getParty().getPartyMembers()[0].setFacingDirection(0);
            gameInit.getFreeRoamState().getCurrentZone().addCharacter(gameInit.getParty().getPartyMembers()[0], 50, 50);

            gameInit.getGameState().setFreeRoamState();
        }
    }
}
