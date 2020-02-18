using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace PrjStarTrek
{
    class Mina
    {
        #region Propriedades e objetos
        public Texture2D imgMinaParada;
        public Texture2D imgMinaAnimacao;
        public Vector2 Posicao;
        float velocidade;

        Rectangle retangulo;
        public int largura;
        int altura;
        int tempoImagem;
        int indiceFrame;

        public bool ativo;

        public int Vida;
        public int Dano;
        #endregion

        public Mina(Game jogo, ContentManager conteudo, Vector2 posicaoInicial)
        {
            #region Valores Iniciais para Posição, Situação e Vida
            Posicao = posicaoInicial;
            velocidade = 2.5f;
            imgMinaParada = conteudo.Load<Texture2D>("images/mine");
            imgMinaAnimacao = conteudo.Load<Texture2D>("images/mine_anim_sprite");
            largura = imgMinaParada.Width;
            altura = imgMinaParada.Height;
            retangulo = new Rectangle(0, 0, largura, altura);
            indiceFrame = 0;
            ativo = true;
            Vida = 100;
            Dano = 20;
            #endregion
        }

        public void AtualizaMina(GameTime tempoJogo, GraphicsDeviceManager tela)
        {
            #region Atualiza posicao da Mina

            #region Animacao
            int tempo = tempoJogo.ElapsedGameTime.Milliseconds;

            tempoImagem += tempo;

            if (tempoImagem > 100)
            {
                indiceFrame++;
                if (indiceFrame == 3)
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

            if (Vida <=0)
            {
                ativo = false;
            }
            #endregion
        }

        public void DesenhaMina(SpriteBatch spriteBatch)
        {
            #region Renderiza o Player
            if (ativo)
            {
                spriteBatch.Draw(imgMinaAnimacao, Posicao, retangulo, Color.White, 0f, Vector2.Zero, 1f, SpriteEffects.None, 0);
            }
            #endregion
        }

        public Rectangle pegaDimensao()
        {
            Rectangle quadrado = new Rectangle((int)Posicao.X, (int)Posicao.Y, largura, altura);
            return quadrado;
        }
    }
}
