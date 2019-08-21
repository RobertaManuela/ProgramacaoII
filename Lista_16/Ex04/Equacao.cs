﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04
{
    class Equacao
    {
        private double A;
        private double B;
        private double C;

        public void SetABC(double x, double y, double z)
        {
            A = x;
            B = y;
            C = z;
        }

        public void GetABC(out double x, out double y, out double z)
        {
            x = A;
            y = B;
            z = C;
        }

        public double Delta()
        {
            return (B * B) - 4 * A * C;
        }

        public bool RaizesReais()
        {
            if (Delta() >= 0 )return true;
            else
                return false;
        }

        public bool X1(out double x)
        {
            x = 0;
            if (RaizesReais() == false || A == 0) return false;
            x = (-B + Math.Sqrt(Delta())) / (2 * A);
            return true;
        }

        public bool X2(out double x)
        {
            x = 0;
            if (RaizesReais() == false || A == 0) return false;
            x = (-B - Math.Sqrt(Delta())) / (2 * A);
            return true;

        }

    }
}
