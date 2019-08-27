using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex07
{
    class Disciplina
    {
        private string nome;
        private int media;
        public Disciplina (string nome, int media)
        {
            this.nome = nome;
            this.media = media;
        }
        public override string ToString()
        {
            return nome;
        }
        public double GetMedia()
        {
            return media;
        }
        
    }
}
