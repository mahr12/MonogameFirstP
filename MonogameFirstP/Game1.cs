using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using SharpDX;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using Color = Microsoft.Xna.Framework.Color;
using Vector2 = Microsoft.Xna.Framework.Vector2;

namespace MonogameFirstP
{
    public class Game1 :  Game
    {

        public Game1()
        {
            GraphicManager.Initialize(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            base.Initialize();
        }

        protected override void LoadContent()
        {
            GraphicManager.spriteBatch = new SpriteBatch(GraphicsDevice);
            GraphicManager.LoadTexture2D();
            CreationManager.Update();

            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here
            EntityManager.Update(gameTime);
            EntityManager.Collision(gameTime);
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            GraphicManager.spriteBatch.Begin();
            EntityManager.Draw(gameTime);
            GraphicManager.spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
