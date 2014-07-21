using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Tactics.Game;
using Tactics.ContentHandlers;

namespace Tactics.PaintHandlers
{
    class PaintHandler
    {

        public PaintHandler()
        {
        }

        public void draw(SpriteBatch spriteBatch, GameInit gameInit, ContentHandler contentHandler)
        {
            if (gameInit.getGameState().getState() == gameInit.getGameState().START_STATE)
            {
                drawStartState(spriteBatch, gameInit, contentHandler);
            }
            else if (gameInit.getGameState().getState() == gameInit.getGameState().FREE_ROAM_STATE)
            {
                drawFreeRoamState(spriteBatch, gameInit, contentHandler);
            }
            else if (gameInit.getGameState().getState() == gameInit.getGameState().BATTLE_STATE)
            {
                drawBattleState(spriteBatch, gameInit, contentHandler);
            }
            else if (gameInit.getGameState().getState() == gameInit.getGameState().PAUSE_STATE)
            {
                drawPauseState(spriteBatch, gameInit, contentHandler);
            }
        }

        private void drawStartState(SpriteBatch spriteBatch, GameInit gameInit, ContentHandler contentHandler)
        {
        }

        private void drawFreeRoamState(SpriteBatch spriteBatch, GameInit gameInit, ContentHandler contentHandler)
        {
            Texture2D texture = contentHandler.getRegionContent()[gameInit.getFreeRoamState().getCurrentRegion()].getTileImages()[gameInit.getRegionFactory().getCurrentZones()[gameInit.getFreeRoamState().getCurrentZone()].getImageMap()[gameInit.getFreeRoamState().getCharacterXPos(), gameInit.getFreeRoamState().getCharacterYPos()]];
            spriteBatch.Draw(texture, new Vector2(400, 400), Color.White);
        }

        private void drawBattleState(SpriteBatch spriteBatch, GameInit gameInit, ContentHandler contentHandler)
        {
        }

        private void drawPauseState(SpriteBatch spriteBatch, GameInit gameInit, ContentHandler contentHandler)
        {
        }
    }
}
