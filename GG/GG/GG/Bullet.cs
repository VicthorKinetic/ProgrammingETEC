using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace GG
{
    class Bullet
    {
        #region Propriedades e objetos
        public Texture2D imgBullet;
        public Vector2 Posicao;
        float velocidade;
        public int Dano;
        public int largura;
        public int altura;
        public bool ativo;
        #endregion

        public Bullet(Game jogo, ContentManager conteudo, Vector2 posicaoInicial)
        {
            #region Valores Iniciais para Posição, Situação e Vida
            Posicao = posicaoInicial;
            velocidade = 20f;
            imgBullet = conteudo.Load<Texture2D>("Images/Bullet");
            largura = imgBullet.Width;
            altura = imgBullet.Height;
            ativo = true;
            Dano = 10;
            #endregion
        }

        public void AtualizaBullet(GraphicsDeviceManager tela)
        {
            Posicao.X += velocidade;
            if (Posicao.X + largura / 2 > tela.PreferredBackBufferWidth)
                ativo = false;

        }

        public void DesenhaBullet(SpriteBatch spriteBatch)
        {
            #region Renderiza o Tiro

            spriteBatch.Draw(imgBullet, Posicao, Color.White);

            #endregion
        }


        public Rectangle pegaDimensao()
        {
            Rectangle quadrado = new Rectangle((int)Posicao.X, (int)Posicao.Y, largura, altura);
            return quadrado;
        }
    }
}