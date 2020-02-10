﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Spelprojekt.Abstract_objects
{
    abstract class GameObject
    {
        protected float currentTexture = 0;
        protected Texture2D[] texture;
        protected Vector2 position;

        public GameObject(Texture2D[] texture, float X, float Y)
        {
            this.texture = texture;
            position.X = X;
            position.Y = Y;
        }

        public virtual void Update(GameWindow window) { }

        public virtual void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture[(int)currentTexture], position, Color.White);
        }

        public virtual bool IncrementTexture()
        {
            //if ()
            return false;
        }

        public virtual bool IncrementTexture(int amount)
        {

            return false;
        }

        public virtual float X { get { return position.X; } }
        public virtual float Y { get { return position.Y; } }
        public virtual float Width { get { return texture[(int)currentTexture].Width; } }
        public virtual float Height { get { return texture[(int)currentTexture].Height; } }
    }

    public interface IUpdate
    {
        void Update(GameWindow window);
    }
}