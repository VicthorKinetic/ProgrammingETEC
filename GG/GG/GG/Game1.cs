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
using GG;

namespace Joginho
{

    public class Game1 : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
 
        Player player;
        List<Enemy> enemy;
        List<Bullet> bullets;
        private bool atirar = true;
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

            #region Iniciando o Player, o Enemy e o Tiro
            player = new Player(this, Content, new Vector2(0, 0));
            
            enemy = new List<Enemy>();
            tempoInstanciamentoAnterior = TimeSpan.Zero;
            tempoInstanciamento = TimeSpan.FromSeconds(2.0f);
            random = new Random();

            bullets = new List<Bullet>();

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

            if (Keyboard.GetState().IsKeyDown(Keys.F))
            {
                if (atirar)
                {
                    AdicionaBullet(new Vector2(player.Posicao.X + player.largura - 20f, player.Posicao.Y + (player.altura / 2) - 14f));
                    atirar = false;
                }
            }

            if (Keyboard.GetState().IsKeyUp(Keys.F))
            {
                atirar = true;
            }

            AtualizaBullet();
            #endregion

            AtualizaColisoes();

            base.Update(gameTime);

        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here

            #region Desenho do Player, do Enemy e do Tiro
            spriteBatch.Begin();
            spriteBatch.Draw(Content.Load<Texture2D>("Images/Fundo pro bixo"), new Vector2(0, 0), Color.White);

            player.DesenhaPlayer(spriteBatch);


            for (int i = 0; i < enemy.Count; i++)
            {
                enemy[i].DesenhaEnemy(spriteBatch);
            }

            for (int i = 0; i < bullets.Count; i++)
            {
                bullets[i].DesenhaBullet(spriteBatch);
            }

            spriteBatch.End();

            base.Draw(gameTime);
            #endregion
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

        #region Adiciona Tiro
        private void AdicionaBullet(Vector2 posicao)
        {
            Bullet bullet = new Bullet (this, Content, posicao);
            bullets.Add(bullet);

        }
        #endregion

        #region Atualiza Tiro
        private void AtualizaBullet()
        {
         for (int i = bullets.Count - 1; i >= 0; i--)
            {
                bullets[i].AtualizaBullet(graphics);

                if (bullets[i].ativo == false)
                {
                    bullets.RemoveAt(i);
                }
            }
        }
        #endregion

        #region Atualiza Colisoes entre Objetos
        private void AtualizaColisoes()
        {
            #region Caixas para Determinar região de Colisão
            Rectangle obj1;
            Rectangle obj2;
            #endregion

            #region Colisao entre Enemy e Player
            obj1 = player.pegaDimensao();

            for (int i = 0; i < enemy.Count; i++)
            {
                obj2 = enemy[i].pegaDimensao();

                if (obj1.Intersects(obj2))
                {
                    if (enemy[i].ativo)
                    {
                        player.Vida = player.Vida - enemy[i].Dano;
                        enemy[i].ativo = false;
                    }

                    if (player.Vida <= 0)
                    {
                        player.ativo = false;
                    }
                }

            }
            #endregion

            #region Colisao entre Enemy e Bullet
            for (int i = 0; i < bullets.Count; i++)
            {
                for (int j = 0; j < enemy.Count; j++)
                {
                    obj1 = bullets[i].pegaDimensao();
                    obj2 = enemy[j].pegaDimensao();
                    if (obj1.Intersects(obj2))
                    {
                        enemy[j].Vida = enemy[j].Vida - bullets[i].Dano;
                        bullets[i].ativo = false;

                        if (enemy[j].Vida <= 0)
                        {
                            enemy[j].ativo = false;
                        }
                    }
                }
            }
            #endregion
        }
        #endregion


    }
 }