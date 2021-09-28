using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.IO;
using System.Numerics;
using System.Text;
using Vector2 = Microsoft.Xna.Framework.Vector2;

namespace MonogameFirstP
{
    class CreationManager
    {
  
        static int timer;


        public static void Charactars(int numberOfCharacters)
        {
            for (int i=0; i <numberOfCharacters; i++)
            {
                Random random = new Random();

                Vector2 position;
                Vector2 movingPosition;
                Rectangle rectangle;
                float speed;

                position = new Vector2(random.Next(0, 500), random.Next(0, 500));
                movingPosition = new Vector2(random.Next(0, 50), random.Next(0, 50));
                rectangle = new Rectangle(random.Next(0, 5), random.Next(0,5), random.Next(0,4), random.Next(0,4));
                speed = random.Next(0, 3);

                Entity tempCreator = new Charactor(position, movingPosition, speed, rectangle);
                EntityManager.AddToEntity(tempCreator);
            }
        }

        public static void Update(GameTime gameTime)
        {
            timer += gameTime.ElapsedGameTime.Milliseconds;
            if(timer >10)
            {
                timer = 0;
                Charactars(6);
            }
        }
    }
}
