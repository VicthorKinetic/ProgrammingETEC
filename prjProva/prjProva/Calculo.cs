using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prjProva
{
    class Calculo
    {
        public int ind = 2;
        public double[] num;
        public int aux = 0;

        public double[] getNum()
        {
            return num;
        }

        public void Calc()
        {
            num = new double[50];

            num[0] = 1;
            num[1] = 1;

            for (int i = 0; i < 48; i++)
            {
                for (int p = i + 1; p > i; p++)
                {

                    num[ind] = num[i] + num[p];
                    ind++;

                    break;
                }
            }
        }

    }
}
