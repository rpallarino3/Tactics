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
using Tactics.Game.Environment.ManipulatableObjects;

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

        private readonly Vector2 BIGBOTDRAW = new Vector2(375, 300);
        private readonly Vector2 SMALLBOTDRAW = new Vector2(375, 350);
        private readonly Vector2 BIGTOPDRAW = new Vector2(375, 100);
        private readonly Vector2 SMALLTOPDRAW = new Vector2(375, 100);

        private readonly Vector2 TOPOPTION = new Vector2(550, 100);
        private readonly Vector2 BOTOPTION = new Vector2(150, 100);

        private readonly Vector2 CHATWINDOWOFFSET = new Vector2(5, 5);

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

        public void draw(SpriteBatch spriteBatch, GameInit gameInit, ContentHandler contentHandler, Color color)
        {
            if (gameInit.getGameState().getState() == gameInit.getGameState().START_STATE)
            {
                drawStartState(spriteBatch, gameInit, contentHandler, color);
            }
            else if (gameInit.getGameState().getState() == gameInit.getGameState().FREE_ROAM_STATE)
            {
                drawFreeRoamState(spriteBatch, gameInit, contentHandler, color);
            }
            else if (gameInit.getGameState().getState() == gameInit.getGameState().BATTLE_STATE)
            {
                drawBattleState(spriteBatch, gameInit, contentHandler, color);
            }
            else if (gameInit.getGameState().getState() == gameInit.getGameState().PAUSE_STATE)
            {
                drawPauseState(spriteBatch, gameInit, contentHandler, color);
            }
        }

        private void drawStartState(SpriteBatch spriteBatch, GameInit gameInit, ContentHandler contentHandler, Color color)
        {
        }

        private void drawFreeRoamState(SpriteBatch spriteBatch, GameInit gameInit, ContentHandler contentHandler, Color color)
        {
            Zone currentZone = gameInit.getFreeRoamState().getCurrentZone();
            List<Vector2> orderedTileList = currentZone.getTileLocations();
            List<int> orderedImageList = currentZone.getImageIdentifiers();
            List<Tile> orderedTiles = currentZone.getOrderedTiles();

            for (int i = orderedTileList.Count - 1; i >= 0; i--)
            {
                Tile currentTile = orderedTiles[i];
                int heightDiff = gameInit.getParty().getPartyMembers()[0].getHeight() - currentTile.getWalkingHeight();
                int xDiff = gameInit.getParty().getPartyMembers()[0].getX() - (int)orderedTileList[i].X;
                int yDiff = gameInit.getParty().getPartyMembers()[0].getY() - (int)orderedTileList[i].Y;
                Vector2 playerOffset = gameInit.getParty().getPartyMembers()[0].getTileDrawOffset();

                Vector2 drawLoc = -playerOffset + NORMALPLAYERDRAWLOCATION + TILEOFFSET + new Vector2((TILESIZE.X / 2) * (xDiff + yDiff), (TILESIZE.Y / 2) * (-xDiff + yDiff) + TILETHICKNESS * heightDiff);
                
                if (currentTile.isSloped())
                {
                    int direction = currentTile.getSlopedOrientation();
                    if (direction == 0)
                    {
                        if (checkIfDisplay(drawLoc, TILESIZE.X, TILESIZE.Y))
                        {
                            spriteBatch.Draw(contentHandler.getRegionContent()[gameInit.getFreeRoamState().getCurrentRegion()].getTopLeftSlope()[orderedImageList[i]], drawLoc, color);
                        }
                    }
                    else if (direction == 1)
                    {
                        if (checkIfDisplay(drawLoc, TILESIZE.X, TILESIZE.Y))
                        {
                            spriteBatch.Draw(contentHandler.getRegionContent()[gameInit.getFreeRoamState().getCurrentRegion()].getTopRightSlope()[orderedImageList[i]], drawLoc, color);
                        }
                    }
                    else if (direction == 2)
                    {
                        if (checkIfDisplay(drawLoc, TILESIZE.X, TILESIZE.Y))
                        {
                            spriteBatch.Draw(contentHandler.getRegionContent()[gameInit.getFreeRoamState().getCurrentRegion()].getBottomRightSlope()[orderedImageList[i]], drawLoc, color);
                        }
                    }
                    else if (direction == 3)
                    {
                        if (checkIfDisplay(drawLoc, TILESIZE.X, TILESIZE.Y))
                        {
                            spriteBatch.Draw(contentHandler.getRegionContent()[gameInit.getFreeRoamState().getCurrentRegion()].getBottomLeftSlope()[orderedImageList[i]], drawLoc, color);
                        }
                    }
                    else if (direction == 4)
                    {
                        if (checkIfDisplay(drawLoc, TILESIZE.X, TILESIZE.Y))
                        {
                            spriteBatch.Draw(contentHandler.getRegionContent()[gameInit.getFreeRoamState().getCurrentRegion()].getTopSlope()[orderedImageList[i]], drawLoc, color);
                        }
                    }
                    else if (direction == 5)
                    {
                        if (checkIfDisplay(drawLoc, TILESIZE.X, TILESIZE.Y))
                        {
                            spriteBatch.Draw(contentHandler.getRegionContent()[gameInit.getFreeRoamState().getCurrentRegion()].getBottomSlope()[orderedImageList[i]], drawLoc, color);
                        }
                    }
                    else if (direction == 6)
                    {
                        if (checkIfDisplay(drawLoc, TILESIZE.X, TILESIZE.Y))
                        {
                            spriteBatch.Draw(contentHandler.getRegionContent()[gameInit.getFreeRoamState().getCurrentRegion()].getRightSlope()[orderedImageList[i]], drawLoc, color);
                        }
                    }
                    else if (direction == 7)
                    {
                        if (checkIfDisplay(drawLoc, TILESIZE.X, TILESIZE.Y))
                        {
                            spriteBatch.Draw(contentHandler.getRegionContent()[gameInit.getFreeRoamState().getCurrentRegion()].getLeftSlope()[orderedImageList[i]], drawLoc, color);
                        }
                    }
                }
                else
                {
                    if (checkIfDisplay(drawLoc, TILESIZE.X, TILESIZE.Y + TILETHICKNESS * (Math.Abs(heightDiff) - 1)))
                    {
                        spriteBatch.Draw(contentHandler.getRegionContent()[gameInit.getFreeRoamState().getCurrentRegion()].getTileImages()[orderedImageList[i]], drawLoc, color);
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
                            spriteBatch.Draw(contentHandler.getRegionContent()[gameInit.getFreeRoamState().getCurrentRegion()].getLeftWallImages()[orderedImageList[i]], leftEdgeLoc, color);
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
                                spriteBatch.Draw(contentHandler.getRegionContent()[gameInit.getFreeRoamState().getCurrentRegion()].getLeftWallImages()[orderedImageList[i]], leftEdgeLoc, color);
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
                            spriteBatch.Draw(contentHandler.getRegionContent()[gameInit.getFreeRoamState().getCurrentRegion()].getRightWallImages()[orderedImageList[i]], rightEdgeLoc, color);
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
                                spriteBatch.Draw(contentHandler.getRegionContent()[gameInit.getFreeRoamState().getCurrentRegion()].getRightWallImages()[orderedImageList[i]], rightEdgeLoc, color);
                            }
                        }
                    }
                }

                if (gameInit.getFreeRoamState().getCurrentZone().getTrafficMap().getObjectBooleanMap()[(int)orderedTileList[i].X, (int)orderedTileList[i].Y])
                {
                    ManipulatableObject obj = gameInit.getFreeRoamState().getCurrentZone().getTrafficMap().getObjectMap()[(int)orderedTileList[i].X, (int)orderedTileList[i].Y];
                    Texture2D texture = contentHandler.getRegionContent()[gameInit.getFreeRoamState().getCurrentRegion()].getObjectContent()[obj.getObjectAnimation().getID()];
                    int rectX = obj.getObjectAnimation().getColumn() * (int)obj.getObjectAnimation().getSectionSize().X;
                    int rectY = obj.getObjectAnimation().getRow() * (int)obj.getObjectAnimation().getSectionSize().Y;
                    int xSize = (int)obj.getObjectAnimation().getSpriteSize().X;
                    int ySize = (int)obj.getObjectAnimation().getSpriteSize().Y;
                    Rectangle rect = new Rectangle(rectX, rectY, xSize, ySize);
                    spriteBatch.Draw(texture, drawLoc + obj.getDrawOffset(), rect, color);
                }

                // do the same for characters

                if (gameInit.getFreeRoamState().getCurrentZone().getTrafficMap().getCharacterBooleanMap()[(int)orderedTileList[i].X, (int)orderedTileList[i].Y])
                {
                    Character character = gameInit.getFreeRoamState().getCurrentZone().getTrafficMap().getCharacterMap()[(int)orderedTileList[i].X, (int)orderedTileList[i].Y];

                    if (character.getX() == orderedTileList[i].X && character.getY() == orderedTileList[i].Y)
                    {
                        Texture2D texture = contentHandler.getCharacterContent().getSpriteSheets()[character.getType()];
                        int rectX = character.getCharacterAnimations().getCurrentAnimationColumn() * (int)character.getCharacterAnimations().getAnimations().getSectionSize().X;
                        int rectY = character.getCharacterAnimations().getCurrentAnimationRow() * (int)character.getCharacterAnimations().getAnimations().getSectionSize().Y;
                        int xSize = (int)character.getCharacterAnimations().getAnimations().getSpriteSize().X;
                        int ySize = (int)character.getCharacterAnimations().getAnimations().getSpriteSize().Y;

                        if (checkIfDisplay(drawLoc + character.getTileDrawOffset() - TILEOFFSET, (float)xSize, (float)ySize))
                        {
                            Rectangle rect = new Rectangle(rectX, rectY, xSize, ySize);
                            spriteBatch.Draw(texture, drawLoc + character.getTileDrawOffset() - TILEOFFSET, rect, color);
                        }
                    }
                }

                if (gameInit.getFreeRoamState().showChatWindow())
                {
                    SpriteFont chatBoxFont = contentHandler.getChatContentHandler().getChatBoxFont();
                    string message = gameInit.getFreeRoamState().getMessage();
                    int size = (int)chatBoxFont.MeasureString(message).X;

                    int index;

                    if (size > 200)
                    {
                        index = size / 20 - 4 + 16;
                    }
                    else
                    {
                        index = size / 10 - 4;
                    }

                    if (index < 0)
                    {
                        index = 0;
                    }
                    else if (index >= contentHandler.getChatContentHandler().getChatBoxes().Count)
                    {
                        index = contentHandler.getChatContentHandler().getChatBoxes().Count - 1;
                    }

                    Vector2 chatDrawLoc;

                    int direction = gameInit.getParty().getPartyMembers()[0].getFacingDirection();

                    if (direction == 0 || direction == 3)
                    {
                        if (size > 200)
                        {
                            chatDrawLoc = BIGBOTDRAW - new Vector2((size - 200) / 2, 0);
                        }
                        else
                        {
                            chatDrawLoc = SMALLBOTDRAW - new Vector2(size / 2, 0);
                        }
                    }
                    else
                    {
                        if (size > 200)
                        { 
                            chatDrawLoc = BIGTOPDRAW - new Vector2((size - 200)/ 2, 0);
                        }
                        else
                        {
                            chatDrawLoc = SMALLTOPDRAW - new Vector2(size / 2 , 0);
                        }
                    }

                    spriteBatch.Draw(contentHandler.getChatContentHandler().getChatBox(index), chatDrawLoc, Color.White);

                    int distance = 0;
                    int line = 0;

                    for (int j = 0; j < gameInit.getFreeRoamState().getParsedMessage().Count; j++)
                    {
                        string currentString = gameInit.getFreeRoamState().getParsedMessage()[j];

                        if (distance + (int)chatBoxFont.MeasureString(currentString).X > 50 + (index % 16) * 10)
                        {
                            distance = 0;
                            line++;
                        }

                        spriteBatch.DrawString(chatBoxFont, currentString, chatDrawLoc + CHATWINDOWOFFSET + new Vector2(distance, 20 * line), Color.White);
                        distance += (int)chatBoxFont.MeasureString(currentString).X;
                    }

                    List<string> options = gameInit.getFreeRoamState().getOptions();

                    if (options.Count != 0)
                    {
                        if (direction == 0 || direction == 3)
                        {
                            chatDrawLoc = BOTOPTION;
                        }
                        else
                        {
                            chatDrawLoc = TOPOPTION;
                        }

                        spriteBatch.Draw(contentHandler.getChatContentHandler().getOptionBox(options.Count), chatDrawLoc, Color.White);
                        line = 0;

                        for (int j = 0; j < options.Count; j++)
                        {
                            spriteBatch.DrawString(chatBoxFont, options[j], drawLoc + CHATWINDOWOFFSET + new Vector2(0, line * 20), Color.White);
                            line++;
                        }
                    }
                    else
                    {
                    }
                }
            }
        }

        private bool checkIfDisplay(Vector2 drawLoc, float width, float height)
        {
            if (drawLoc.X < SCREENSIZE.X && drawLoc.X + width >= -10)
            {
                if (drawLoc.Y < SCREENSIZE.Y && drawLoc.Y + height >= -10)
                {
                    return true;
                }
            }
            return false;
        }

        private void drawBattleState(SpriteBatch spriteBatch, GameInit gameInit, ContentHandler contentHandler, Color color)
        {
        }

        private void drawPauseState(SpriteBatch spriteBatch, GameInit gameInit, ContentHandler contentHandler, Color color)
        {
        }
    }
}
