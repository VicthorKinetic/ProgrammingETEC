using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace Joginho
{

    public class Game1 : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        
        Player player;
        List<Enemy> enemy;
        TimeSpan tempoInstanciamento;
        TimeSpan tempoInstanciamentoAnterior;
        Random random;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            #region Iniciando o Player e o Enemy
            player = new Player(this, Content, new Vector2(0, 0));
            
            enemy = new List<Enemy>();
            tempoInstanciamentoAnterior = TimeSpan.Zero;
            tempoInstanciamento = TimeSpan.FromSeconds(2.0f);
            random = new Random();
            #endregion

            #region Configuração de Tela
            graphics.PreferredBackBufferWidth = 1000;
            graphics.PreferredBackBufferHeight = 600;
            graphics.IsFullScreen = false;
            IsMouseVisible = false;
            Window.Title = "The Lakitu Traitor - RUN FOR YOUR LIFE";
            graphics.ApplyChanges();
            #endregion




            base.Initialize();
        }


        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);
            

            // TODO: use this.Content to load your game content here
        }


        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }


        protected override void Update(GameTime gameTime)
        {
            // Allows the game to exit
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed)
                this.Exit();

            // TODO: Add your update logic here
            #region Atualiza o Player, o Enemy e o Tiro

            player.AtualizaPlayer(gameTime, graphics);

            AtualizaEnemy(gameTime);
            #endregion

        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here

            #region Desenho do Player e do Enemy
            spriteBatch.Begin();

            player.DesenhaPlayer(spriteBatch);


            for (int i = 0; i < enemy.Count; i++)
            {
                enemy[i].DesenhaEnemy(spriteBatch);
            }
            #endregion

            spriteBatch.End();


            base.Draw(gameTime);
        }

        #region Adiciona Enemy
        private void AdicionaEnemy()
        {
            float posX = GraphicsDevice.Viewport.Width;
            float posY = random.Next(1, GraphicsDevice.Viewport.Height - 168);
            Enemy coisa = new Enemy(this, Content, new Vector2(posX, posY));
            enemy.Add(coisa);
        }
        #endregion

        #region Atualiza Enemy
        private void AtualizaEnemy(GameTime gameTime)
        {
            if (gameTime.TotalGameTime - tempoInstanciamentoAnterior > tempoInstanciamento)
            {
                tempoInstanciamentoAnterior = gameTime.TotalGameTime;
                AdicionaEnemy();
            }
            for (int i = enemy.Count - 1; i >= 0; i--)
            {
                enemy[i].AtualizaEnemy(gameTime, graphics);

                if (enemy[i].ativo == false)
                {
                    enemy.RemoveAt(i);
                }
            }
        }
        #endregion

        }
    }