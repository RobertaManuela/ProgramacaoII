using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01
{
    class Viagem
    {
        private double Distancia;
        public void SetDistancia(double d) { Distancia = d; }
        public double GetDistancia() { return Distancia; }
        private double tempo;
        public void SetTempo(double t) { tempo = t; }
        public double GetTempo() { return tempo; }
        public double CalcVelocidade() { return Distancia / tempo; }
    }
}
