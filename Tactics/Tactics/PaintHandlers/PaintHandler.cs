using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Tactics.Game;
using Tactics.ContentHandlers;
using Tactics.Game.Environment;

namespace Tactics.PaintHandlers
{
    class PaintHandler
    {
        private readonly Vector2 NORMALPLAYERSIZE = new Vector2(24, 34);
        private readonly Vector2 ZOOMEDNORMALPLAYERSIZE = new Vector2(12, 17);

        private readonly Vector2 SCREENSIZE = new Vector2(750, 500);
        private readonly Vector2 TILESIZE = new Vector2(36, 18);
        private readonly int TILETHICKNESS = 8;

        private readonly Vector2 NORMALPLAYERDRAWLOCATION = new Vector2(363, 233);
        private readonly Vector2 TILEOFFSET = new Vector2(-17, 3);

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
            List<Vector2> orderedTileList = gameInit.getFreeRoamState().getCurrentZones()[gameInit.getFreeRoamState().getCurrentZone()].getTileLocations();
            List<int> orderedImageList = gameInit.getFreeRoamState().getCurrentZones()[gameInit.getFreeRoamState().getCurrentZone()].getImageIdentifiers();
            List<int> orderedTileHeights = gameInit.getFreeRoamState().getCurrentZones()[gameInit.getFreeRoamState().getCurrentZone()].getTileHeights();

            for (int i = orderedTileList.Count - 1; i >= 0; i--)
            {
                int heightDiff = gameInit.getFreeRoamState().getCharacterHeight() - orderedTileHeights[i];
                int xDiff = gameInit.getFreeRoamState().getCharacterXPos() - (int)orderedTileList[i].X;
                int yDiff = gameInit.getFreeRoamState().getCharacterYPos() - (int)orderedTileList[i].Y;

                Vector2 drawLoc = NORMALPLAYERDRAWLOCATION + TILEOFFSET + new Vector2((TILESIZE.X / 2) * (xDiff + yDiff), (TILESIZE.Y / 2) * (-xDiff + yDiff) + TILETHICKNESS * heightDiff);

                if (checkIfDisplay(drawLoc, TILESIZE.X, TILESIZE.Y + TILETHICKNESS *(Math.Abs(heightDiff) - 1)))
                {
                    spriteBatch.Draw(contentHandler.getRegionContent()[gameInit.getFreeRoamState().getCurrentRegion()].getTileImages()[orderedImageList[i]], drawLoc, Color.White);
                }
            }
        }

        private bool checkIfDisplay(Vector2 drawLoc, float width, float height)
        {
            if (drawLoc.X < SCREENSIZE.X && drawLoc.X + width > 0)
            {
                if (drawLoc.Y < SCREENSIZE.Y && drawLoc.Y + height > 0)
                {
                    return true;
                }
            }
            return false;
        }

        private void drawBattleState(SpriteBatch spriteBatch, GameInit gameInit, ContentHandler contentHandler)
        {
        }

        private void drawPauseState(SpriteBatch spriteBatch, GameInit gameInit, ContentHandler contentHandler)
        {
        }
    }
}
