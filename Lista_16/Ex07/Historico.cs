using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex07
{
    class Historico
    {
        private string aluno;
        int k;
        private Disciplina[] disc = new Disciplina[10];
        public Historico(string aluno)
        {
            this.aluno = aluno;
        }
        public void Inserir(Disciplina d)
        {
           if(k < 10)
             disc[k++] = d;
        }
        public Disciplina[] Listar()
        {
            Disciplina[] novo = new Disciplina[k];
            Array.Copy(disc, novo, k);
            return novo;
        }
        public double IRA()
        {
            if (k = 0) return 0;
            double x;
            foreach (Disciplina d in discs)
              if( d != null    x = x + d.GetMedia();
            return x / k;
                
        }
    }
}
