﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace DeiInTerra
{
    /// <summary>
    /// Main class for Dei In Terra
    /// </summary>
    public class DeiInTerra : Game
    {
        private GraphicsDeviceManager graphics;
        private SpriteBatch spriteBatch;
        private Texture2D shop, player1, player2;
        private SpriteFont font;
        private int health = 100, mana = 100, score = 0, gold = 8000;
        private int totalHealth = 100, totalMana = 100;
        private string levelnumber = "1-Shop";
        private float ScreenWidth = 800, ScreenHeight = 600;

        public DeiInTerra()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            graphics.PreferredBackBufferHeight = (int)ScreenHeight;
            graphics.PreferredBackBufferWidth = (int)ScreenWidth;
            graphics.IsFullScreen = false;
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
            shop = Content.Load<Texture2D>("Graphics/shop");
            font = Content.Load<SpriteFont>("GameFont");
            player1 = Content.Load<Texture2D>("Graphics/knight class");
            // TODO: use this.Content to load your game content here
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
            Content.Unload();
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            string displayedHealth = "HP: " + health + "/" + totalHealth, displayedMana = "MP: " + mana + "/" + totalMana;
            spriteBatch.Begin();
            spriteBatch.Draw(shop, new Rectangle(0, 0, 800, 600), Color.White);
            spriteBatch.DrawString(font, displayedHealth, new Vector2(ScreenWidth * (0.875f), ScreenHeight * (10 / 600f)), Color.Red);
            spriteBatch.DrawString(font, displayedMana, new Vector2(ScreenWidth * (0.875f), ScreenHeight * (35 / 600f)), Color.Purple);
            spriteBatch.DrawString(font, "Level " + levelnumber, new Vector2(ScreenWidth * (.0125f), ScreenHeight * (10 / 600f)), Color.Black);
            spriteBatch.DrawString(font, "Gold: " + gold, new Vector2(ScreenWidth * (0.875f), ScreenHeight * (60 / 600f)), Color.Gold);
            spriteBatch.Draw(player1, new Vector2(ScreenWidth * (302/800f), ScreenHeight * (405/600f)));
            spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}