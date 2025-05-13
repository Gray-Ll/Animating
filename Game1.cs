using System;
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Animating
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        Random gen = new Random();

        Texture2D tribblegreyT;
        Rectangle tribblegreyRect;
        Vector2 tribblegreySpeed;

        Texture2D tribblebrownT;
        Rectangle tribblebrownRect;
        Vector2 tribblebrownSpeed;

        Texture2D tribblecreamT;
        Rectangle tribblecreamRect;
        Vector2 tribblecreamSpeed;

        Texture2D tribbleorangeT;
        Rectangle tribbleorangeRect;
        Vector2 tribbleorangeSpeed;

        Rectangle window;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }   
        
        
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            window = new Rectangle(0, 0, 800, 600);
            _graphics.PreferredBackBufferWidth = window.Width;
            _graphics.PreferredBackBufferHeight = window.Height;
            _graphics.ApplyChanges();

            tribblegreyRect = new Rectangle(gen.Next(0, 500), 0, 50, 50);
            tribblegreySpeed = new Vector2(5, 8);

            tribblebrownRect = new Rectangle(gen.Next(0, 500), 60, 70, 70);
            tribblebrownSpeed = new Vector2(7, 4);

            tribblecreamRect = new Rectangle(gen.Next(0, 500), 0, 150, 150);
            tribblecreamSpeed = new Vector2(3, 2);

            tribbleorangeRect = new Rectangle(gen.Next(0, 500), 200, 100, 100);
            tribbleorangeSpeed = new Vector2(6, -3);

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            tribblegreyT = Content.Load<Texture2D>("tribbleGrey");
            tribblebrownT = Content.Load<Texture2D>("tribbleBrown");
            tribblecreamT = Content.Load<Texture2D>("tribbleCream");
            tribbleorangeT = Content.Load<Texture2D>("tribbleOrange");

            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            //Grey
            tribblegreyRect.X += (int)tribblegreySpeed.X;
            if (tribblegreyRect.Right >= window.Width || tribblegreyRect.Left <=0)
            {
                tribblegreySpeed.X *= -1;
                tribblegreyRect = new Rectangle(400, 0, 400, 400);
            }
            tribblegreyRect.Y += (int)tribblegreySpeed.Y;
            if (tribblegreyRect.Bottom >= window.Height || tribblegreyRect.Y <=0)
            {
                tribblegreySpeed.Y *= -1;
            }
            //Brown
            tribblebrownRect.X += (int)tribblebrownSpeed.X;
            if (tribblebrownRect.Right >= window.Width || tribblebrownRect.Left <=0)
            {
                tribblebrownSpeed.X *= -1;
            }
            tribblebrownRect.Y += (int)tribblebrownSpeed.Y;
            if (tribblebrownRect.Bottom >= window.Height || tribblebrownRect.Y <=0)
            {
                tribblebrownSpeed.Y *= -1;
            }
            //Cream
            tribblecreamRect.X += (int)tribblecreamSpeed.X;
            if (tribblecreamRect.Right >= window.Width || tribblecreamRect.Left <= 0)
            {
                tribblecreamSpeed.X *= -1;
            }
            tribblecreamRect.Y += (int)tribblecreamSpeed.Y;
            if (tribblecreamRect.Bottom >= window.Height || tribblecreamRect.Y <= 0)
            {
                tribblecreamSpeed.Y *= -1;
            }
            //Orange
            tribbleorangeRect.X += (int)tribbleorangeSpeed.X;
            if (tribbleorangeRect.Right >= window.Width || tribbleorangeRect.Left <= 0)
            {
                tribbleorangeSpeed.X *= -1;
            }
            tribbleorangeRect.Y += (int)tribbleorangeSpeed.Y;
            if (tribbleorangeRect.Bottom >= window.Height || tribbleorangeRect.Y <= 0)
            {
                tribbleorangeSpeed.Y *= -1;
            }
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Maroon);

            _spriteBatch.Begin();

            _spriteBatch.Draw(tribblegreyT, tribblegreyRect, Color.White);
            _spriteBatch.Draw(tribblebrownT, tribblebrownRect, Color.White);
            _spriteBatch.Draw(tribblecreamT, tribblecreamRect, Color.White);
            _spriteBatch.Draw(tribbleorangeT, tribbleorangeRect, Color.White);


            _spriteBatch.End();

            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}