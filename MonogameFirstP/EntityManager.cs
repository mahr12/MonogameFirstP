using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace MonogameFirstP
{

    class EntityManager
    {
        static Entity firstEntity;
        static Entity lastEntity;
        public static int uniquIdCounter;

        public EntityManager()
        {
            firstEntity = null;
            lastEntity = null;
            uniquIdCounter = 0;

        }

        public static void AddToEntity(Entity addTo)
        {
            uniquIdCounter++;
            addTo.uniqueId = uniquIdCounter;
            
            if (firstEntity != null)
            {
                lastEntity.nextEntity = addTo;
            }
            else
            {
                firstEntity = addTo;
            }
            lastEntity = addTo;
        }



        public static void Collision(GameTime gameTime)
        {
            Entity stempEntity = firstEntity;
            while (stempEntity != null)
            {
                stempEntity = stempEntity.nextEntity;
                while (stempEntity != null)
                {
                    //if()
                    Console.WriteLine("Collision");
                    stempEntity = stempEntity.nextEntity;
                }
            }
        }
        public static void Update(GameTime gameTime)
        {
            Entity stempEntity = firstEntity;
            while (stempEntity != null)
            {
                if (stempEntity.isActive)
                {
                    stempEntity.Update(gameTime);
                    stempEntity = stempEntity.nextEntity;
                }
            }

        }

        public static void Draw(GameTime gameTime)
        {
            Entity temporaryP = firstEntity;
            while (temporaryP != null)
            {
                if (temporaryP.isActive)
                {
                    temporaryP.Draw(gameTime);
                    temporaryP = temporaryP.nextEntity;
                    Console.WriteLine(uniquIdCounter);
                }
            }
        }

    }
}