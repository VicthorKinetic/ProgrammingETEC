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
    class Enemy
    {
        #region Propriedades e objetos
        public Texture2D imgEnemy;
        public Texture2D imgEnemyAnimation;
        public Vector2 Posicao;
        float velocidade;

        Rectangle retangulo;
        public int largura;
        int altura;
        int tempoImagem;
        int indiceFrame;

        public bool ativo;
        #endregion

        public Enemy(Game jogo, ContentManager conteudo, Vector2 posicaoInicial)
        {
            #region Valores Iniciais para Posição, Situação e Vida
            Posicao = posicaoInicial;
            velocidade = 2.5f;
            imgEnemy = conteudo.Load<Texture2D>("Images/Enemy_Sprite");
            imgEnemyAnimation = conteudo.Load<Texture2D>("Images/Enemy_Animation");
            largura = imgEnemy.Width;
            altura = imgEnemy.Height;
            retangulo = new Rectangle(0, 0, largura, altura);
            indiceFrame = 0;
            ativo = true;
            #endregion
        }

        public void AtualizaEnemy(GameTime tempoJogo, GraphicsDeviceManager tela)
        {
            #region Atualiza posicao do Enemy

            #region Animacao
            int tempo = tempoJogo.ElapsedGameTime.Milliseconds;

            tempoImagem += tempo;

            if (tempoImagem > 100)
            {
                indiceFrame++;
                if (indiceFrame == 4)
                    indiceFrame = 0;
                retangulo.X = largura * indiceFrame;
                tempoImagem = 0;
            }
            #endregion

            Posicao.X -= velocidade;
            if (Posicao.X + largura < 0)
            {
                ativo = false;
            }
            #endregion
        }

        public void DesenhaEnemy(SpriteBatch spriteBatch)
        {
            #region Renderiza o Enemy
            if (ativo)
            {
                spriteBatch.Draw(imgEnemyAnimation, Posicao, retangulo, Color.White, 0f, Vector2.Zero, 1f, SpriteEffects.None, 0);
            }
            #endregion
        }
    }
}

