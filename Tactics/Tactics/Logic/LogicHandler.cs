using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Tactics.KeyHandlers;
using Tactics.Game;
using Tactics.ContentHandlers;

namespace Tactics.Logic
{
    class LogicHandler
    {
        private SaveGameHandler saveGameHandler;
        private TransitionHandler transitionHandler;
        private MovementHandler movementHandler;

        public LogicHandler()
        {
            saveGameHandler = new SaveGameHandler();
            transitionHandler = new TransitionHandler();
            movementHandler = new MovementHandler();
        }

        public void updateLogic(GameInit gameInit, KeyHandler keyHandler, ContentHandler content)
        {
            if (gameInit.getGameState().getState() == gameInit.getGameState().START_STATE)
            {
                updateStartLogic(gameInit, keyHandler, content);
            }
            else if (gameInit.getGameState().getState() == gameInit.getGameState().FREE_ROAM_STATE)
            {
                updateFreeRoamLogic(gameInit, keyHandler, content);
            }
            else if (gameInit.getGameState().getState() == gameInit.getGameState().BATTLE_STATE)
            {
                updateBattleLogic(gameInit, keyHandler, content);
            }
            else if (gameInit.getGameState().getState() == gameInit.getGameState().PAUSE_STATE)
            {
            }
        }


        private void updateStartLogic(GameInit gameInit, KeyHandler keyHandler, ContentHandler content)
        {
        }

        private void updateFreeRoamLogic(GameInit gameInit, KeyHandler keyHandler, ContentHandler content)
        {
            updateFreeRoamPlayerLogic(gameInit, keyHandler, content);
        }

        private void updateFreeRoamPlayerLogic(GameInit gameInit, KeyHandler keyHandler, ContentHandler content)
        {
            if (!checkActions(gameInit, keyHandler, content))
            {
                if (!checkMove(gameInit, keyHandler, content))
                {
                    if (!checkMenu(gameInit, keyHandler, content))
                    {
                    }
                }
            }
        }

        private bool checkActions(GameInit gameInit, KeyHandler keyHandler, ContentHandler content)
        {
            return true;
        }

        private bool checkMove(GameInit gameInit, KeyHandler keyHandler, ContentHandler content)
        {
            return true;
        }

        private bool checkMenu(GameInit gameInit, KeyHandler keyHandler, ContentHandler content)
        {
            return true;
        }


        private void updateBattleLogic(GameInit gameInit, KeyHandler keyHandler, ContentHandler content)
        {
        }


        //pass in some save data as well
        public void loadGame(GameInit gameInit, ContentHandler content)
        {
            saveGameHandler.loadGame(gameInit, content, transitionHandler);
        }

    }
}
