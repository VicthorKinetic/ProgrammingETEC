using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Joginho
{
    class Player
    {
        #region Propriedades e objetos
        public Texture2D imgPlayer;
        public Texture2D imgPlayerAnimacao;
        public Texture2D imgPlayerAtual;

        public int Vida;
        public Vector2 Posicao;
        float velocidade;

        public bool ativo;
        Rectangle retangulo;
        public int largura;
        public int altura;
        int tempoImagem;
        int indiceFrame;
        #endregion

        public Player(Game jogo, ContentManager conteudo, Vector2 posicaoInicial)
        {
            #region Valores Iniciais para Posição, Situação e Vida
            Posicao = posicaoInicial;
            velocidade = 0.5f;
            imgPlayer = conteudo.Load<Texture2D>("Images/Player_Sprite");
            imgPlayerAnimacao = conteudo.Load<Texture2D>("Images/Player_Animation");
            imgPlayerAtual = imgPlayer;
            largura = imgPlayerAtual.Width;
            altura = imgPlayerAtual.Height;
            retangulo = new Rectangle(0, 0, largura, altura);
            indiceFrame = 0;
            Vida = 50;
            ativo = true;
            #endregion
        }

        public void AtualizaPlayer(GameTime tempoJogo, GraphicsDeviceManager tela)
        {
            #region Atualiza posicao do Player

            int tempo = tempoJogo.ElapsedGameTime.Milliseconds;

            tempoImagem += tempo;

            if (tempoImagem > 75)
            {
                indiceFrame++;
                if (indiceFrame == 6)
                    indiceFrame = 0;
                retangulo.X = largura * indiceFrame;
                tempoImagem = 0;
            }

            #region Testa teclas de Movimento
            if (Keyboard.GetState().IsKeyDown(Keys.Right) || Keyboard.GetState().IsKeyDown(Keys.Left)
                || Keyboard.GetState().IsKeyDown(Keys.Up) || Keyboard.GetState().IsKeyDown(Keys.Down))
            {
                imgPlayerAtual = imgPlayerAnimacao;

                #region Aqui estão as teclas de movimento afetando X e Y
                if (Keyboard.GetState().IsKeyDown(Keys.Right))
                {
                    Posicao.X += tempo * velocidade;
                }

                if (Keyboard.GetState().IsKeyDown(Keys.Down))
                {
                    Posicao.Y += tempo * velocidade;
                }

                if (Keyboard.GetState().IsKeyDown(Keys.Left))
                {
                    Posicao.X -= tempo * velocidade;
                }

                if (Keyboard.GetState().IsKeyDown(Keys.Up))
                {
                    Posicao.Y -= tempo * velocidade;
                }
                #endregion
            }
            else
            {
                imgPlayerAtual = imgPlayer;
                retangulo.X = 0;
                indiceFrame = 0;
            }
            #endregion

            #region Restrição de Valor para não passar limites da Tela
            Posicao.X = MathHelper.Clamp(Posicao.X, 0, tela.GraphicsDevice.Viewport.Width - imgPlayer.Width);
            Posicao.Y = MathHelper.Clamp(Posicao.Y, 0, tela.GraphicsDevice.Viewport.Height - imgPlayer.Height);
            #endregion

            #endregion
        }

        public void DesenhaPlayer(SpriteBatch spriteBatch)
        {
            #region Renderiza o Player
            if(ativo)
            spriteBatch.Draw(imgPlayerAnimacao, Posicao, retangulo, Color.White, 0f, Vector2.Zero, 1f, SpriteEffects.None, 0);
            #endregion
        }

        public Rectangle pegaDimensao()
        {
            Rectangle quadrado = new Rectangle((int)Posicao.X, (int)Posicao.Y, largura, altura);
            return quadrado;
        }
    }
}
