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

namespace Pong
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class Game1 : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        Texture2D goomba;
        int goombaX = 100;
        int goombaY = 200;
        int goombaWidth = 64;
        int goombaHeight = 64;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
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

            playerOne = Content.Load<Texture2D>("paddle");
            playerTwo = Content.Load<Texture2D>("paddle");

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

            // TODO: Add your update logic here
            if (Keyboard.GetState().IsKeyDown(Keys.Up))
            {
                goombaY -= 5;
            }
            if (Keyboard.GetState().IsKeyDown(Keys.Down))
            {
                goombaY += 5;
            }
            if (Keyboard.GetState().IsKeyDown(Keys.Left))
            {
                goombaX -= 5;
            }
            if (Keyboard.GetState().IsKeyDown(Keys.Right))
            {
                goombaX += 5;
            }


            //edge checks
            if (goombaX > graphics.PreferredBackBufferWidth)
            {
                goombaX = 0 - goombaWidth;
            }

            if (goombaX < 0 - goombaWidth)
            {
                goombaX = graphics.PreferredBackBufferWidth;
            }

            if (goombaY > graphics.PreferredBackBufferHeight)
            {
                goombaY = 0 - goombaHeight;
            }

            if (goombaY < 0 - goombaWidth)
            {
                goombaY = graphics.PreferredBackBufferHeight;
            }

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            spriteBatch.Begin();
            // TODO: Add your drawing code here

            spriteBatch.Draw(goomba, new Rectangle(goombaX, goombaY, goombaWidth, goombaHeight), Color.Gold);

            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
