using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace PrjStarTrek
{
    class FundoAnim
    {
        #region Propriedades e Objetos
        Texture2D textura;
        Vector2[] posicoes;
        int velocidade;
        #endregion

        public FundoAnim(ContentManager content, String caminhoTextura, int larguraJanela, int velocidade)
        {
            textura = content.Load<Texture2D>(caminhoTextura);
            this.velocidade = velocidade;
            posicoes = new Vector2[larguraJanela / textura.Width + 1];

            for (int i = 0; i < posicoes.Length; i++)
            {
                posicoes[i] = new Vector2(i * textura.Width, 0);
            }
        }

        public void AtualizaFundoAnim()
        {
            for (int i = 0; i < posicoes.Length; i++)
            {
                posicoes[i].X += velocidade;

                if (posicoes[i].X <= -textura.Width)
                {
                    posicoes[i].X = textura.Width; //* (posicoes.Length - 1);
                }
            }
        }

        public void DesenhaFundoAnim(SpriteBatch spriteBatch)
        {
            for (int i = 0; i < posicoes.Length; i++)
            {
                spriteBatch.Draw(textura, posicoes[i], Color.White);
            }
        }


    }
}
