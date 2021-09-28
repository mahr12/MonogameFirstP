using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MonogameFirstP
{
    class GraphicManager
    {
        public static GraphicsDeviceManager graphigcsDeviceManager;
        public static SpriteBatch spriteBatch;
        public static Game1 myGame;
        public static Dictionary<string, Texture2D> gameSprite;
        public static void Initialize (Game1 game1)
        {
            gameSprite = new Dictionary<string, Texture2D>();
            graphigcsDeviceManager = new GraphicsDeviceManager(game1);
            myGame = game1;
        }


        public static void LoadTexture2D ()   //Laddar upp min min i en lista som jag sedan bara koppierar för att göra flera objekter
        {
            string picturetPath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "/Content/Image/" + "apple.png";

            using (Stream textureToStream = new FileStream(picturetPath, FileMode.Open))
            {
                Texture2D temTexture= Texture2D.FromStream(myGame.GraphicsDevice, textureToStream);
                gameSprite.Add("apple",temTexture);
               // myPicture = Texture2D.FromStream(GraphicManager.myGame.GraphicsDevice, toStream);
            }
        }
    }
}
