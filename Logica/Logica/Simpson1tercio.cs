﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Simpson1tercio
    {
        public static double f(double x)
        {
            //double e = 2.71828;
            //return ((x * x * x * x * x - 1) * (Math.Exp(x)) - 10);
            //return ((12.5 * (x + 2)) / (Math.Pow(x, 2) + 4 * x + 5)) + 2;
            //return (((10 * x + 20) / (x * x + 4 * x + 5)) + 2);
            //return ((1.20*x + 13.82) - (-0.94*x + 32.63));
            //return ((-0.02 * (Math.Pow(x, 3)) + 0.54 * (Math.Pow(x, 2)) - 4.03 * x + 36.01) - (-0.01 * (Math.Pow(x, 3)) + 0.07 * (Math.Pow(x, 2)) + 1.92 * x + 11.99));
            //return Math.Abs(Math.Pow(x,2) - 4) + 2 * x;
            //return (0.2 + 25 * x - 200 * (Math.Pow(x, 2)) + 675 * (Math.Pow(x, 3)) - 900 * (Math.Pow(x, 4)) + 400 * (Math.Pow(x, 5)));
            //return (Math.Asin(x));
            //return ((1 / (x + 0.5)) + ((0.25) * Math.Pow(x, 2)));
            //return (Math.Log(1 + Math.Pow(x, 2)));
            return ((Math.Pow(2.71828, x)) * (1 - 0.5* Math.Pow(x,2)));
            //return (((-0.75) * Math.Pow(x, 2)) - x + 4) - (((0.0625) * Math.Pow(x, 4)) - ((0.25) * Math.Pow(x, 3)));


        }
        public double integral(double extremoizquierdo, double extremoderecho)
        {
            double h = (extremoderecho - extremoizquierdo) / 2;
            double x1 = (extremoizquierdo + extremoderecho) / 2;
            double suma = (h/3) * (f(extremoizquierdo) + (4 * f(x1)) + f(extremoderecho));
            return suma;
        }
    }
}
