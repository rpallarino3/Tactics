using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Tactics.Game;
using Tactics.ContentHandlers;
using Tactics.Game.Environment;
using Tactics.Game.Characters;

namespace Tactics.PaintHandlers
{
    class PaintHandler
    {
        private readonly Vector2 NORMALPLAYERSIZE = new Vector2(24, 34);
        private readonly Vector2 ZOOMEDNORMALPLAYERSIZE = new Vector2(12, 17);

        private readonly Vector2 SCREENSIZE = new Vector2(750, 500);
        private readonly Vector2 TILESIZE = new Vector2(36, 18);
        private readonly Vector2 EDGESIZE = new Vector2(18, 17);
        private readonly int TILETHICKNESS = 8;

        private readonly Vector2 NORMALPLAYERDRAWLOCATION = new Vector2(363, 233);
        private readonly Vector2 TILEOFFSET = new Vector2(-5, 20);


        // something is wrong here
        private readonly Vector2 SLOPEBLOFF = new Vector2(1, 0);
        private readonly Vector2 SLOPEBROFF = new Vector2(0, 0);
        private readonly Vector2 SLOPEBOFF = new Vector2(1, 0);
        private readonly Vector2 SLOPELOFF = new Vector2(1, 8);
        private readonly Vector2 SLOPEROFF = new Vector2(-1, 8);
        private readonly Vector2 SLOPETLOFF = new Vector2(1, 8);
        private readonly Vector2 SLOPETROFF = new Vector2(1, 8);
        private readonly Vector2 SLOPETOFF = new Vector2(1, 8);

        private readonly Vector2 TLSIZE = new Vector2(34, 18);
        private readonly Vector2 TRSIZE = new Vector2(34, 18);
        private readonly Vector2 BRSIZE = new Vector2(35, 26);
        private readonly Vector2 BLSIZE = new Vector2(35, 26);
        private readonly Vector2 TSIZE = new Vector2(34, 10);
        private readonly Vector2 BSIZE = new Vector2(34, 26);
        private readonly Vector2 RSIZE = new Vector2(36, 18);
        private readonly Vector2 LSIZE = new Vector2(36, 18);

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
            Zone currentZone = gameInit.getFreeRoamState().getCurrentZones()[gameInit.getFreeRoamState().getCurrentZone()];
            List<Vector2> orderedTileList = currentZone.getTileLocations();
            List<int> orderedImageList = currentZone.getImageIdentifiers();
            List<Tile> orderedTiles = currentZone.getOrderedTiles();


            for (int i = orderedTileList.Count - 1; i >= 0; i--)
            {
                Tile currentTile = orderedTiles[i];
                int heightDiff = gameInit.getFreeRoamState().getCharacterHeight() - currentTile.getWalkingHeight();
                int xDiff = gameInit.getFreeRoamState().getCharacterXPos() - (int)orderedTileList[i].X;
                int yDiff = gameInit.getFreeRoamState().getCharacterYPos() - (int)orderedTileList[i].Y;

                Vector2 drawLoc = NORMALPLAYERDRAWLOCATION + TILEOFFSET + new Vector2((TILESIZE.X / 2) * (xDiff + yDiff), (TILESIZE.Y / 2) * (-xDiff + yDiff) + TILETHICKNESS * heightDiff);
                

                if (currentTile.isSloped())
                {
                    int direction = currentTile.getSlopedOrientation();
                    if (direction == 0)
                    {
                        if (checkIfDisplay(drawLoc, TILESIZE.X, TILESIZE.Y))
                        {
                            spriteBatch.Draw(contentHandler.getRegionContent()[gameInit.getFreeRoamState().getCurrentRegion()].getTopLeftSlope()[orderedImageList[i]], drawLoc, Color.White);
                        }
                    }
                    else if (direction == 1)
                    {
                        if (checkIfDisplay(drawLoc, TILESIZE.X, TILESIZE.Y))
                        {
                            spriteBatch.Draw(contentHandler.getRegionContent()[gameInit.getFreeRoamState().getCurrentRegion()].getTopRightSlope()[orderedImageList[i]], drawLoc, Color.White);
                        }
                    }
                    else if (direction == 2)
                    {
                        if (checkIfDisplay(drawLoc, TILESIZE.X, TILESIZE.Y))
                        {
                            spriteBatch.Draw(contentHandler.getRegionContent()[gameInit.getFreeRoamState().getCurrentRegion()].getBottomRightSlope()[orderedImageList[i]], drawLoc, Color.White);
                        }
                    }
                    else if (direction == 3)
                    {
                        if (checkIfDisplay(drawLoc, TILESIZE.X, TILESIZE.Y))
                        {
                            spriteBatch.Draw(contentHandler.getRegionContent()[gameInit.getFreeRoamState().getCurrentRegion()].getBottomLeftSlope()[orderedImageList[i]], drawLoc, Color.White);
                        }
                    }
                    else if (direction == 4)
                    {
                        if (checkIfDisplay(drawLoc, TILESIZE.X, TILESIZE.Y))
                        {
                            spriteBatch.Draw(contentHandler.getRegionContent()[gameInit.getFreeRoamState().getCurrentRegion()].getTopSlope()[orderedImageList[i]], drawLoc, Color.White);
                        }
                    }
                    else if (direction == 5)
                    {
                        if (checkIfDisplay(drawLoc, TILESIZE.X, TILESIZE.Y))
                        {
                            spriteBatch.Draw(contentHandler.getRegionContent()[gameInit.getFreeRoamState().getCurrentRegion()].getBottomSlope()[orderedImageList[i]], drawLoc, Color.White);
                        }
                    }
                    else if (direction == 6)
                    {
                        if (checkIfDisplay(drawLoc, TILESIZE.X, TILESIZE.Y))
                        {
                            spriteBatch.Draw(contentHandler.getRegionContent()[gameInit.getFreeRoamState().getCurrentRegion()].getRightSlope()[orderedImageList[i]], drawLoc, Color.White);
                        }
                    }
                    else if (direction == 7)
                    {
                        if (checkIfDisplay(drawLoc, TILESIZE.X, TILESIZE.Y))
                        {
                            spriteBatch.Draw(contentHandler.getRegionContent()[gameInit.getFreeRoamState().getCurrentRegion()].getLeftSlope()[orderedImageList[i]], drawLoc, Color.White);
                        }
                    }
                }
                else
                {
                    if (checkIfDisplay(drawLoc, TILESIZE.X, TILESIZE.Y + TILETHICKNESS * (Math.Abs(heightDiff) - 1)))
                    {
                        spriteBatch.Draw(contentHandler.getRegionContent()[gameInit.getFreeRoamState().getCurrentRegion()].getTileImages()[orderedImageList[i]], drawLoc, Color.White);
                    }
                }

                // change this to look at next tiles
                if (orderedTileList[i].X == currentZone.getTileWidth() - 1)
                {
                    for (int j = 0; j < currentTile.getWalkingHeight(); j++)
                    {
                        Vector2 leftEdgeLoc = drawLoc + new Vector2(0, TILESIZE.Y / 2 + TILETHICKNESS * (j + 1));

                        if (checkIfDisplay(leftEdgeLoc, EDGESIZE.X, EDGESIZE.Y))
                        {
                            spriteBatch.Draw(contentHandler.getRegionContent()[gameInit.getFreeRoamState().getCurrentRegion()].getLeftWallImages()[orderedImageList[i]], leftEdgeLoc, Color.White);
                        }

                    }
                    
                }
                else
                {
                    int leftHeightDiff = currentTile.getWalkingHeight() - currentZone.getTileMap()[(int)orderedTileList[i].X + 1, (int)orderedTileList[i].Y].getWalkingHeight();

                    if (leftHeightDiff > 1)
                    {
                        for (int j = 0; j < leftHeightDiff - 1; j++)
                        {
                            Vector2 leftEdgeLoc = drawLoc + new Vector2(0, TILESIZE.Y / 2 + TILETHICKNESS * (j + 1));

                            if (checkIfDisplay(leftEdgeLoc, EDGESIZE.X, EDGESIZE.Y))
                            {
                                spriteBatch.Draw(contentHandler.getRegionContent()[gameInit.getFreeRoamState().getCurrentRegion()].getLeftWallImages()[orderedImageList[i]], leftEdgeLoc, Color.White);
                            }
                        }
                    }
                }

                if (orderedTileList[i].Y == 0)
                {
                    for (int j = 0; j < currentTile.getWalkingHeight(); j++)
                    {
                        Vector2 rightEdgeLoc = drawLoc + new Vector2(0, TILESIZE.Y / 2 + TILETHICKNESS * (j + 1)) + new Vector2(TILESIZE.X / 2, 0);

                        if (checkIfDisplay(rightEdgeLoc, EDGESIZE.X, EDGESIZE.Y))
                        {
                            spriteBatch.Draw(contentHandler.getRegionContent()[gameInit.getFreeRoamState().getCurrentRegion()].getRightWallImages()[orderedImageList[i]], rightEdgeLoc, Color.White);
                        }
                    }
                }
                else
                {
                    int rightHeightDiff = currentTile.getWalkingHeight() - currentZone.getTileMap()[(int)orderedTileList[i].X, (int)orderedTileList[i].Y - 1].getWalkingHeight();

                    if (rightHeightDiff > 1)
                    {
                        for (int j = 0; j < rightHeightDiff - 1; j++)
                        {
                            Vector2 rightEdgeLoc = drawLoc + new Vector2(0, TILESIZE.Y / 2 + TILETHICKNESS * (j + 1)) + new Vector2(TILESIZE.X / 2, 0);

                            if (checkIfDisplay(rightEdgeLoc, EDGESIZE.X, EDGESIZE.Y))
                            {
                                spriteBatch.Draw(contentHandler.getRegionContent()[gameInit.getFreeRoamState().getCurrentRegion()].getRightWallImages()[orderedImageList[i]], rightEdgeLoc, Color.White);
                            }
                        }
                    }
                }
                
                if (orderedTileList[i].X == gameInit.getFreeRoamState().getCharacterXPos())
                {
                    if (orderedTileList[i].Y == gameInit.getFreeRoamState().getCharacterYPos())
                    {
                        Texture2D texture = contentHandler.getCharacterContent().getSpriteSheets()[gameInit.getParty().getPartyMembers()[0].getType()];
                        Character character = gameInit.getParty().getPartyMembers()[0];
                        int rectX = character.getCharacterAnimations().getCurrentAnimationColumn() * (int)character.getCharacterAnimations().getAnimations().getSectionSize().X;
                        int rectY = character.getCharacterAnimations().getCurrentAnimationRow() * (int)character.getCharacterAnimations().getAnimations().getSectionSize().Y;
                        int xSize = (int)character.getCharacterAnimations().getAnimations().getSpriteSize().X;
                        int ySize = (int)character.getCharacterAnimations().getAnimations().getSpriteSize().Y;
                        Rectangle sourceRec = new Rectangle(rectX, rectY, xSize, ySize);
                        spriteBatch.Draw(texture, NORMALPLAYERDRAWLOCATION, sourceRec, Color.White);
                    }
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
