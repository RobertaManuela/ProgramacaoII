using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03
{
    class Retangulo
    {
        private double Base;
        private double Altura;
        public void SetBase(double b) { Base = b; }
        public void SetAltura(double a) { Altura = a; }
        public double GetBase() { return Base; }
        public double GetAltura() { return Altura;}
        public double CalcArea() { return Base * Altura; }
        public double CalcDiagonal() { return Math.Sqrt(Base * Base) + (Altura * Altura); }
    }
}

