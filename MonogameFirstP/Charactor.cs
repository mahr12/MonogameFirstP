using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using MonoGame;
using System;
using System.Collections.Generic;
using System.IO;
using System.Numerics;
using System.Text;
using Vector2 = Microsoft.Xna.Framework.Vector2;

namespace MonogameFirstP
{
    class Charactor : Entity
    {
        Texture2D temptexture;
        Vector2 startPosition;
        Vector2 movingPosition;
        Rectangle rectangle;
        float speed;
        string imageKey;
        public Charactor(Vector2 startPosition, Vector2 movingPosition, float speed, Rectangle rectangle)
        {
            imageKey = "apple";
            this.rectangle = rectangle;
            this.movingPosition = movingPosition;
            this.startPosition = startPosition;
            this.speed = speed /100;
        }

        public override void Update(GameTime gameTime)
        {
            startPosition += movingPosition * speed *gameTime.ElapsedGameTime.Milliseconds;
            if(startPosition.X <=0 && movingPosition.X <0)
            {
                movingPosition.X *= -1;
            }
            else if (startPosition.Y <= 0 && movingPosition.Y <0)
            {
                movingPosition.Y *= -1;
            }
            else if (startPosition.X >= 500 -rectangle.X && movingPosition.X > 0)
            {
                movingPosition.X *= -1;
            }
            else if (startPosition.Y >= 250 -rectangle.Y && movingPosition.Y > 0)
            {
                movingPosition.Y *= -1;
            }
            base.Update(gameTime);
        }

        public override void Draw(GameTime gameTime)
        {

            
            GraphicManager.gameSprite.TryGetValue(imageKey, out temptexture);
            GraphicManager.spriteBatch.Draw(temptexture, startPosition, Color.White);
            base.Draw(gameTime);
        }

    }
}
