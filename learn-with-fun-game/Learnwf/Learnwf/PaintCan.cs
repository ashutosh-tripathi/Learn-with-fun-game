using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Media;
namespace Learnwf
{
    public class PaintCan : ThreeColorGameObject
    {
        protected Color targetcolor;
        protected float minVelocity;
        protected float positionOffset;
        

        public PaintCan(ContentManager Content, float positionOffset, Color targetcol)
            : base(Content.Load<Texture2D>("spr_can_red"),
                   Content.Load<Texture2D>("spr_can_green"),
                   Content.Load<Texture2D>("spr_can_blue"))
        {
            this.positionOffset = positionOffset;
            
            targetcolor = targetcol;
            minVelocity = 60;
            Reset();
        }

        public override void Update(GameTime gameTime)
        {
            if (velocity.Y == 0.0f && Game1.Random.NextDouble() < 0.01)
            {
                velocity = CalculateRandomVelocity();
                Color = CalculateRandomColor();
            }
            Vector2 distanceVector = ((Game1.GameWorld.Ball.Position + Game1.GameWorld.Ball.Center) - (position + Center));
            if (Math.Abs(distanceVector.X) < Center.X && Math.Abs(distanceVector.Y) < Center.Y)
            {
                Color = Game1.GameWorld.Ball.Color;
                Game1.GameWorld.Ball.Reset();
            }

            if (Game1.GameWorld.IsOutsideWorld(position))
            {
                if (color == targetcolor)
                {
                    Game1.GameWorld.Score += 10;
                   
                }
                else
                    Game1.GameWorld.Lives--;
                Reset();
            }
            minVelocity += 0.001f;
            base.Update(gameTime);
        }

        public override void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(currentColor, position, null, Color.White, (float)Math.Sin(position.Y / 50.0) * 0.05f, Vector2.Zero, 1.0f, SpriteEffects.None, 0);
        }

        public override void Reset()
        {
            base.Reset();
            position = new Vector2(positionOffset, -currentColor.Height);
            velocity = Vector2.Zero;
        }

        public void ResetMinVelocity()
        {
            minVelocity = 60;
        }

        public Vector2 CalculateRandomVelocity()
        {
            return new Vector2(0.0f, (float)Game1.Random.NextDouble() * 30 + minVelocity);
        }

        public Color CalculateRandomColor()
        {
            int randomval = Game1.Random.Next(3);
            if (randomval == 0)
                return Color.Red;
            else if (randomval == 1)
                return Color.Green;
            else
                return Color.Blue;
        }
    }
}
