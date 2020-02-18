using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace PrjStarTrek
{
    class Phaser
    {
        #region Propriedades e Objetos
        public Texture2D imgPhaser;
        public Vector2 Posicao;
        public bool ativo;
        public int Dano;
        float velocidade;
        int largura;
        int altura;
        #endregion

        public Phaser(Game jogo, ContentManager conteudo, Vector2 posicaoInicial)
        {
            #region Inicia os valores de Textura, posicao, Dano e velocidade
            Posicao = posicaoInicial;
            velocidade = 20f;
            imgPhaser = conteudo.Load<Texture2D>("images/phaser");
            largura = imgPhaser.Width;
            altura = imgPhaser.Height;
            Posicao = posicaoInicial;
            ativo = true;
            Dano = 20;
            #endregion
        }

        public void AtualizaPhaser(GraphicsDeviceManager tela)
        {
            Posicao.X += velocidade;
            if (Posicao.X + largura / 2 > tela.PreferredBackBufferWidth)
                ativo = false;
        }

        public void DesenhaPhaser(SpriteBatch spriteBatch)
        {
            #region Renderiza o Player
            spriteBatch.Draw(imgPhaser, Posicao, Color.White);
            #endregion
        }

        public Rectangle pegaDimensao()
        {
            Rectangle quadrado = new Rectangle((int)Posicao.X, (int)Posicao.Y, largura, altura);
            return quadrado;
        }
    }
}
