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

namespace PrjStarTrek
{
    public class Game1 : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        #region Objetos e Variáveis

        #region Objetos para criação do Player
        Player player;
        #endregion

        #region Objetos para Criação de Minas
        List<Mina> minas;
        TimeSpan tempoInstanciamento;
        TimeSpan tempoInstanciamentoAnterior;
        Random random;
        #endregion

        #region Objetos para Fundo
        Texture2D fundoPrincipal;
        FundoAnim fundo2;
        FundoAnim fundo3;
        #endregion

        #region Objetos e Variáveis para Controle dos Tiros
        private bool atirar = false;
        List<Phaser> phasers;
        #endregion

        #region Objeto de Texto
        SpriteFont fonte;
        #endregion

        #endregion

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            #region Configuração de Tela
            graphics.PreferredBackBufferWidth = 1000;
            graphics.PreferredBackBufferHeight = 600;
            graphics.IsFullScreen = false;
            IsMouseVisible = false;
            Window.Title = "Star Trek TNG - Campo de Minas";
            graphics.ApplyChanges();
            #endregion

            #region Instancia os fundos do efeito Parallax
            fundo2 = new FundoAnim(Content, @"images\fundo_camada_2", graphics.PreferredBackBufferWidth, -3);
            fundo3 = new FundoAnim(Content, @"images\fundo_camada_3", graphics.PreferredBackBufferWidth, -1);
            #endregion

            #region Iniciando o Player
            player = new Player(this, Content, new Vector2(20, 300));
            #endregion

            #region Iniciando Lista de Minas
            minas = new List<Mina>();
            tempoInstanciamentoAnterior = TimeSpan.Zero;
            tempoInstanciamento = TimeSpan.FromSeconds(2.0f);
            random = new Random();
            #endregion

            #region Iniciando o Phaser
            phasers = new List<Phaser>();
            #endregion

            #region Instancia e Carrega a Fonte
            fonte = Content.Load<SpriteFont>("fonts/fonte");
            #endregion

            base.Initialize();
        }

        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
            fundoPrincipal = Content.Load<Texture2D>("images/fundo_camada_1");
        }

        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        protected override void Update(GameTime gameTime)
        {
            // Allows the game to exit
            #region Tecla de Finalizar o Jogo
            if (Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();
            #endregion

            // TODO: Add your update logic here
            #region Atualiza o Player
            player.AtualizaPlayer(gameTime, graphics);
            #endregion

            #region Atualiza Minas
            AtualizaMina(gameTime);
            #endregion

            #region Atualiza Fundo Animado
            fundo2.AtualizaFundoAnim();
            fundo3.AtualizaFundoAnim();
            #endregion

            #region Atualiza Phaser
            if (Keyboard.GetState().IsKeyDown(Keys.F))
            {
                if (atirar)
                {
                    AdicionaPhaser(new Vector2(player.Posicao.X + player.largura - 20f, player.Posicao.Y + (player.altura/2) -14f));
                    atirar = false;
                }
            }

            if (Keyboard.GetState().IsKeyUp(Keys.F))
            {
                atirar = true;
            }

            AtualizaPhaser();
            #endregion

            AtualizaColisoes();

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            spriteBatch.Begin();

            #region Renderiza o Fundo Principal
            spriteBatch.Draw(fundoPrincipal, Vector2.Zero, Color.White);
            fundo2.DesenhaFundoAnim(spriteBatch);
            fundo3.DesenhaFundoAnim(spriteBatch);
            #endregion

            #region Renderiza o Player
            player.DesenhaPlayer(spriteBatch);
            #endregion

            #region Renderização das Minas
            for (int i = 0; i < minas.Count; i++)
            {
                minas[i].DesenhaMina(spriteBatch);
            }
            #endregion

            #region Renderiza os Phasers instanciados
            for (int i = 0; i < phasers.Count; i++)
            {
                phasers[i].DesenhaPhaser(spriteBatch);
            }
            #endregion

            #region Textos de Vida e Pontuacao
            spriteBatch.DrawString(fonte, "pontos: 0", new Vector2(GraphicsDevice.Viewport.TitleSafeArea.X+10f, GraphicsDevice.Viewport.TitleSafeArea.Y), Color.White);
            spriteBatch.DrawString(fonte, "vida: " + player.Vida, new Vector2(GraphicsDevice.Viewport.TitleSafeArea.X+10f, GraphicsDevice.Viewport.TitleSafeArea.Y + 30), Color.White);
            #endregion

            spriteBatch.End();

            base.Draw(gameTime);
        }

        // --------------------------------------------------- INICIO DE MÉTODOS PERSONALIZADOS

        #region Adiciona Mina
        private void AdicionaMina()
        {
            float posX = GraphicsDevice.Viewport.Width;
            float posY = random.Next(100, GraphicsDevice.Viewport.Height - 100);
            Mina mina = new Mina(this, Content, new Vector2(posX, posY));
            minas.Add(mina);
        }
        #endregion

        #region Atualiza Mina
        private void AtualizaMina(GameTime gameTime)
        {
            if (gameTime.TotalGameTime - tempoInstanciamentoAnterior > tempoInstanciamento)
            {
                tempoInstanciamentoAnterior = gameTime.TotalGameTime;
                AdicionaMina();
            }
            for (int i = minas.Count - 1; i >= 0; i--)
            {
                minas[i].AtualizaMina(gameTime, graphics);

                if (minas[i].ativo == false)
                {
                    minas.RemoveAt(i);
                }
            }
        }
        #endregion

        #region AtualizaPhaser
        private void AtualizaPhaser()
        {
            for (int i = phasers.Count - 1; i >= 0; i--)
            {
                phasers[i].AtualizaPhaser(graphics);

                if (phasers[i].ativo == false)
                {
                    phasers.RemoveAt(i);
                }
            }
        }
        #endregion

        #region AdicionaPhaser
        private void AdicionaPhaser(Vector2 posicao)
        {
            Phaser phaser = new Phaser(this, Content, posicao);
            phasers.Add(phaser);
        }
        #endregion

        #region Atualiza Colisoes entre Objetos
        private void AtualizaColisoes()
        {
            #region Caixas para Determinar região de Colisão
            Rectangle obj1;
            Rectangle obj2;
            #endregion

            #region Colisao entre Mina e Enterprise
            obj1 = player.pegaDimensao();

            for (int i = 0; i < minas.Count; i++)
            {
                obj2 = minas[i].pegaDimensao();

                if (obj1.Intersects(obj2))
                {
                    if (minas[i].ativo)
                    {
                        player.Vida -= minas[i].Dano;
                        minas[i].ativo = false;
                    }

                    if (player.Vida <= 0)
                    {
                        player.ativo = false;
                    }
                }

            }
            #endregion

            #region Colisao entre Mina e Phaser
            for (int i = 0; i < phasers.Count; i++)
            {
                for (int j = 0; j < minas.Count; j++)
                {
                    obj1 = phasers[i].pegaDimensao();
                    obj2 = minas[j].pegaDimensao();
                    if (obj1.Intersects(obj2))
                    {
                        minas[j].Vida -= phasers[i].Dano;
                        phasers[i].ativo = false;
                    }
                }
            }
            #endregion
        }
        #endregion
    }
}
