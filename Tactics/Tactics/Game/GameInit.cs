﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Tactics.Game.Characters;
using Tactics.Game.Environment;
using Tactics.Game.Chat;
using Tactics.Game.Inventory;

namespace Tactics.Game
{
    class GameInit
    {

        private GameState gameState;
        private FreeRoamState freeRoamState;
        private RegionFactory regionFactory;
        private CharacterFactory characterFactory;
        private Party party;
        private MessageBlockFactory messageBlockFactory;
        private Bag bag;

        public GameInit()
        {
            gameState = new GameState();
            freeRoamState = new FreeRoamState();
            regionFactory = new RegionFactory();
            characterFactory = new CharacterFactory();
            messageBlockFactory = new MessageBlockFactory();
            bag = new Bag();
            party = new Party();
        }

        public GameState getGameState()
        {
            return gameState;
        }

        public Bag getBag()
        {
            return bag;
        }

        public MessageBlockFactory getMessageBlockFactory()
        {
            return messageBlockFactory;
        }

        public FreeRoamState getFreeRoamState()
        {
            return freeRoamState;
        }

        public RegionFactory getRegionFactory()
        {
            return regionFactory;
        }

        public CharacterFactory getCharacterFactory()
        {
            return characterFactory;
        }

        public Party getParty()
        {
            return party;
        }

    }
}
