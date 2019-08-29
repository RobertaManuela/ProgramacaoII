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
        private int k;
        private Disciplina[] discs = new Disciplina[10];

        public Historico(string aluno)
        {
            this.aluno = aluno;
        }

        public void Inserir(Disciplina d)
        {
            if (k < 10)
                discs[k++] = d;//Insere no histórico, k armazena a quantidade de disciplinas existentes
        }

        public Disciplina[] Listar()
        {
            Disciplina[] poc = new Disciplina[k]; //k disciplinas existentes
            Array.Copy(discs, poc, k); //Copia para um novo vetor apenas as posições ocupadas e lista as mesmas
            return poc;
        }

        public double IRA()
        {
            if (k == 0) return 0;
            double x = 0;
            foreach (Disciplina d in discs)
                if (d != null)  x = x + d.GetMedia();
            return x / k;

        }

        public void Excluir(int x)
        {
            for (int i = x; i < k; i++) 
            {
                discs[i] = discs[i + 1];
            }
            k--;
        }
    }
}
