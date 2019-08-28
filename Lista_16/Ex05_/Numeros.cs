using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex05_
{
    class Numeros
    {
        private int Inicio;
        private int Fim;

        public void SetInicio(int i)
        {
            Inicio = i;
        }

        public void SetFim(int f)
        {
            Fim = f;
        }

        public int GetInicio()
        {
            return Inicio;
        }

        public int GetFim()
        {
            return Fim;
        }

        public int[] Calcular(bool bp, bool bi)
        {
            int[] intervalo = new int[Fim - Inicio + 1];
           int cont = 0;
            for (int z = Inicio; z <= Fim; z++)
            {
               
                if (z % 2 == 0 && bp == true && bi == false){
                    intervalo[cont] = z;
                    ++cont;
                }
                if(z % 2 != 0 && bp == false && bi == true)
                {
                    intervalo[cont] = z;
                    ++cont;
                }
                if(bp == true && bi == true)
                {
                    intervalo[cont] = z;
                    ++cont;
                }
            }
            int[] intervalo2 = new int[cont];
            Array.Copy(intervalo, intervalo2, cont);

            return intervalo2;
        }


    }
}
