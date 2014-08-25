using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Tactics.Game;
using Tactics.ContentHandlers;
using Tactics.Game.Environment;
using Tactics.Game.Environment.ManipulatableObjects.Objects;

using Microsoft.Xna.Framework;

namespace Tactics.Logic
{
    class TransitionHandler
    {
        private readonly int FADE_THRESHOLD = 9;
        private bool transitioning;
        private Color fadeColor;
        private bool fadeOut;
        private int fadeCounter;

        private int destination;
        private bool regionTrans;
        private Vector2 destinationTile;
        private List<Color> fadeColors;

        public TransitionHandler()
        {
            transitioning = false;
            fadeColor = Color.White;
            fadeOut = false;
            fadeCounter = 0;
            fadeColors = new List<Color>();

            fadeColors.Add(Color.White);
            fadeColors.Add(new Color(225, 225, 225));
            fadeColors.Add(new Color(200, 200, 200));
            fadeColors.Add(new Color(175, 175, 175));
            fadeColors.Add(new Color(150, 150, 150));
            fadeColors.Add(new Color(125, 125, 125));
            fadeColors.Add(new Color(100, 100, 100));
            fadeColors.Add(new Color(75, 75, 75));
            fadeColors.Add(new Color(30, 30, 30));
            fadeColors.Add(Color.Black);
        }

        public void createRegion(GameInit gameInit, ContentHandler content, int regionNumber, int zoneNumber)
        {
            gameInit.getFreeRoamState().setCurrentRegion(regionNumber);
            gameInit.getRegionFactory().getZoneFactories()[regionNumber].createZones();
            gameInit.getFreeRoamState().setCurrentZones(gameInit.getRegionFactory().getZoneFactories()[regionNumber].getRegionZones());
            gameInit.getFreeRoamState().setCurrentZone(zoneNumber);
            content.getRegionContent()[regionNumber].loadContent();
        }

        public void startTransition(GameInit gameInit, Tile currentTile)
        {
            transitioning = true;
            fadeOut = true;
            fadeCounter = 0;
            destination = currentTile.getDestination();
            regionTrans = currentTile.isRegionTransition();
            destinationTile = currentTile.getDestinationTile();
        }

        public void startTransition(GameInit gameInit, Door door)
        {
            transitioning = true;
            fadeOut = true;
            fadeCounter = 0;
            destination = door.getDestination();
            regionTrans = false;
            destinationTile = door.getDestinationTile();
        }

        public void continueTransition(GameInit gameInit)
        {
            if (fadeOut)
            {
                fadeCounter++;

                if (fadeCounter == FADE_THRESHOLD)
                {
                    fadeOut = false;
                    transition(gameInit);
                }

                fadeColor = fadeColors[fadeCounter];
            }
            else
            {
                fadeCounter--;

                if (fadeCounter == 0)
                {
                    transitioning = false;
                }

                fadeColor = fadeColors[fadeCounter];
            }
        }

        public void transition(GameInit gameInit)
        {
            if (regionTrans)
            {
            }
            else
            {
                gameInit.getFreeRoamState().setCurrentZone(destination);
                gameInit.getParty().getPartyMembers()[0].setXPosition((int)destinationTile.X);
                gameInit.getParty().getPartyMembers()[0].setYPosition((int)destinationTile.Y);
                gameInit.getParty().getPartyMembers()[0].setHeight(gameInit.getFreeRoamState().getCurrentZone().getTileMap()[(int)destinationTile.X, (int)destinationTile.Y].getWalkingHeight());
            }
        }

        public bool isTransitioning()
        {
            return transitioning;
        }

        public Color getFadeColor()
        {
            return fadeColor;
        }
    }
}
