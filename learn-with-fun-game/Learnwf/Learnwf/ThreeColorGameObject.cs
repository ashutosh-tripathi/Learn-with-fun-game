﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
namespace Learnwf
{
   public  class ThreeColorGameObject
    {
        protected Texture2D colorRed, colorGreen, colorBlue;
        protected Texture2D currentColor;
        protected Vector2 position, velocity;
        protected Color color;

        public ThreeColorGameObject(Texture2D colorRed, Texture2D colorGreen, Texture2D colorBlue)
        {
            this.colorRed = colorRed;
            this.colorGreen = colorGreen;
            this.colorBlue = colorBlue;
            Color = Color.Blue;
            position = Vector2.Zero;
            velocity = Vector2.Zero;
        }

        public virtual void HandleInput(InputHelper inputHelper)
        {
        }

        public virtual void Update(GameTime gameTime)
        {
            position += velocity * (float)gameTime.ElapsedGameTime.TotalSeconds;
        }

        public virtual void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(currentColor, position, Color.White);
        }

        public virtual void Reset()
        {
            Color = Color.Blue;
        }

        public Vector2 Center
        {
            get { return new Vector2(currentColor.Width, currentColor.Height) / 2; }
        }

        public Vector2 Position
        {
            get { return position; }
        }

        public Color Color
        {
            get { return color; }
            set
            {
                if (value != Color.Red && value != Color.Green && value != Color.Blue)
                    return;
                color = value;
                if (color == Color.Red)
                    currentColor = colorRed;
                else if (color == Color.Green)
                    currentColor = colorGreen;
                else if (color == Color.Blue)
                    currentColor = colorBlue;
            }
        }
    }
}