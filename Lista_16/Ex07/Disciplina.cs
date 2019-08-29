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
        private string semestre;
        private int media;
        private string apre;

        public Disciplina(string nome, string s, int media, bool aprovado)
        {
            this.nome = nome;
            this.semestre = s;
            this.media = media;

            if (aprovado == true) apre = "Aprovado";
            else apre = "Reprovado";
        }

        public override string ToString() //Imprime no listbox
        {
            return $"{nome} - {semestre} - {media} - {apre}";
        }

        public int GetMedia()
        {
            return media;
        }

    }
}
