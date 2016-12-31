using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Learnwf
{
   public class GameWorld
    {
        public int score;
        protected Texture2D background, gameover;
        protected Texture2D scorebar;
        protected SpriteFont gameFont;
        public Ball ball;
        public PaintCan can1, can2, can3;
        public Cannon cannon;
        protected int lives;
        protected Texture2D livesSprite;
        public GameWorld(ContentManager Content)
        {
            gameFont = Content.Load<SpriteFont>("GameFont");

            gameover = Content.Load<Texture2D>("spr_gameover");
            livesSprite = Content.Load<Texture2D>("spr_lives");

            background = Content.Load<Texture2D>("spr_background");
            scorebar = Content.Load<Texture2D>("spr_scorebar");
            cannon = new Cannon(Content);
            ball = new Ball(Content);
            can1 = new PaintCan(Content, 450.0f, Color.Red);
            can2 = new PaintCan(Content, 575.0f, Color.Green);
            can3 = new PaintCan(Content, 700.0f, Color.Blue);

            lives = 5;
        }

        public void HandleInput(InputHelper inputHelper)
        {
            if (lives > 0)
            {
                cannon.HandleInput(inputHelper);
                ball.HandleInput(inputHelper);
            }
            else if (inputHelper.KeyPressed(Keys.Space))
            {
                 Learn f4=new Learn();
                f4.ShowDialog();
                Reset();
 

               
            }
        }

        public void Update(GameTime gameTime)
        {
            if (lives <= 0)
                return;
            ball.Update(gameTime);
            can1.Update(gameTime);
            can2.Update(gameTime);
            can3.Update(gameTime);
        }

        public void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            spriteBatch.Begin();
            spriteBatch.Draw(background, Vector2.Zero, Color.White);
            spriteBatch.Draw(scorebar, new Vector2(10, 10), Color.White);
            ball.Draw(gameTime, spriteBatch);
            cannon.Draw(gameTime, spriteBatch);
            can1.Draw(gameTime, spriteBatch);
            can2.Draw(gameTime, spriteBatch);
            can3.Draw(gameTime, spriteBatch);
            spriteBatch.DrawString(gameFont, "Score: " + score, new Vector2(20, 18), Color.White);
            for (int i = 0; i < lives; i++)
                spriteBatch.Draw(livesSprite, new Vector2(i * livesSprite.Width + 15, 60), Color.White);
            if (lives <= 0)
                spriteBatch.Draw(gameover, new Vector2(Game1.Screen.X - gameover.Width, Game1.Screen.Y - gameover.Height) / 2, Color.White);
            spriteBatch.DrawString(gameFont, "Instructions:", new Vector2(0, 150), Color.Black);
            spriteBatch.DrawString(gameFont, "Paint cans using like colored balls ", new Vector2(0, 180), Color.Black);
            spriteBatch.DrawString(gameFont, "Use R,G and B to change color", new Vector2(0, 210), Color.Black);
            spriteBatch.End();

        }

       

        public void Reset()
        {
            if (cprogram1.quiztaken == 1|| cprogram2.quiztaken==1||apti1.quiztaken==1||apti2.quiztaken==1)
            {
              
                score = 0;
                lives = 5;
                cannon.Reset();
                ball.Reset();
                can1.Reset();
                can2.Reset();
                can3.Reset();
                can1.ResetMinVelocity();
                can2.ResetMinVelocity();
                can3.ResetMinVelocity();
            }
            else
            {
                Mainform mf = new Mainform();
                mf.ShowDialog();
                mf.Close();
            }
            
        }

        public Ball Ball
        {
            get { return ball; }
        }

        public Cannon Cannon
        {
            get { return cannon; }
        }

        public int Score
        {
            get { return score; }
            set { score = value; }
        }

        public bool IsOutsideWorld(Vector2 position)
        {
            return position.X < 0 || position.X > Game1.Screen.X || position.Y > Game1.Screen.Y;
        }

        public int Lives
        {
            get { return lives; }
            set { lives = value; }
        }
    }
}