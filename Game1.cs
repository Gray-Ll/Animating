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

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;

            
        }
        Random gen = new Random();
        int rnd;

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
        

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            window = new Rectangle(0, 0, 800, 600);
            _graphics.PreferredBackBufferWidth = window.Width;
            _graphics.PreferredBackBufferHeight = window.Height;
            _graphics.ApplyChanges();

            tribblegreyRect = new Rectangle(rnd, 0, 100, 100);
            tribblegreySpeed = new Vector2(5, 3);

            tribblebrownRect = new Rectangle(0, 0, 100, 100);
            tribblebrownSpeed = new Vector2(7, 4);

            tribblecreamRect = new Rectangle(0, 0, 100, 100);
            tribblecreamSpeed = new Vector2(3, 2);

            tribbleorangeRect = new Rectangle(0, 0, 100, 100);
            tribbleorangeSpeed = new Vector2(6, 3);

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            tribblegreyT = Content.Load<Texture2D>("tribbleGrey");

            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            tribblegreyRect.X += (int)tribblegreySpeed.X;
            if (tribblegreyRect.Right >= window.Width || tribblegreyRect.Left <=0)
            {
                tribblegreySpeed.X *= -1;
            }
            tribblegreyRect.Y += (int)tribblegreySpeed.Y;
            if (tribblegreyRect.Bottom >= window.Height || tribblegreyRect.Y <=0)
            {
                tribblegreySpeed.Y *= -1;
            }
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            _spriteBatch.Begin();

            _spriteBatch.Draw(tribblegreyT, tribblegreyRect, Color.White);


            _spriteBatch.End();

            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}
