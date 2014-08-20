using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

using Tactics.Game;
using Tactics.Debug;
using Tactics.ContentHandlers;
using Tactics.KeyHandlers;
using Tactics.PaintHandlers;
using Tactics.Logic;

namespace Tactics
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class Game1 : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        private GameInit game;
        private Debugger debugger;
        private ContentHandler contentHandler;
        private PaintHandler paintHandler;
        private KeyHandler keyHandler;
        private LogicHandler logicHandler;

        private ContentManager npcAnimationContent;
        private ContentManager menuContent;
        private ContentManager zoneContent;
        private ContentManager battleContent;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            graphics.PreferredBackBufferWidth = 750;
            graphics.PreferredBackBufferHeight = 500;
            graphics.ApplyChanges();
            IsFixedTimeStep = true;
            TargetElapsedTime = TimeSpan.FromSeconds(1.0f / 30.0f);

            Content.RootDirectory = "Content";
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            npcAnimationContent = new ContentManager(Content.ServiceProvider, Content.RootDirectory);
            menuContent = new ContentManager(Content.ServiceProvider, Content.RootDirectory);
            zoneContent = new ContentManager(Content.ServiceProvider, Content.RootDirectory);
            battleContent = new ContentManager(Content.ServiceProvider, Content.RootDirectory);

            game = new GameInit();
            debugger = new Debugger();
            contentHandler = new ContentHandler(npcAnimationContent, menuContent, zoneContent, battleContent);
            paintHandler = new PaintHandler();
            keyHandler = new KeyHandler();
            logicHandler = new LogicHandler();
            logicHandler.loadGame(game, contentHandler);
            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);
            //load the menu content at the start of the game
            //contentHandler.getRegionContent()[game.getFreeRoamState().getCurrentRegion()].loadContent();

            // TODO: use this.Content to load your game content here
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// all content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            // Allows the game to exit
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed)
                this.Exit();
            if (Keyboard.GetState().IsKeyDown(Keys.F1))
            {
                TargetElapsedTime = TimeSpan.FromSeconds(1.0f / 3.0f);
            }
            if (Keyboard.GetState().IsKeyDown(Keys.F2))
            {
                TargetElapsedTime = TimeSpan.FromSeconds(1.0f / 30.0f);
            }
            // TODO: Add your update logic here
            keyHandler.updateKeys(Keyboard.GetState());
            logicHandler.updateLogic(game, keyHandler, contentHandler);
            base.Update(gameTime);

            
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {

            // TODO: Add your drawing code here
            spriteBatch.Begin();
            paintHandler.draw(spriteBatch, game, contentHandler);
            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
