using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01
{
    class viagem
    {
        private double Distancia;
        private double Tempo;
        public void SetDistancia(double d) { Distancia = d; }
        public void SetTempo(double t) { tempo = t; }
        public double GetDistancia() { return Distancia; }
        public double GetTempo() { return Tempo; }
        public double CalcArea() { return 4 * Math.PI * raio * raio; }
        public double CalcVolume() { return 4 * Math.PI * raio * raio * raio / 3; }
    }
}
