using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Simpson3octavosSimple
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
            //return (0.2 + (25 * x) - (200 * Math.Pow(x, 2)) + (675 * Math.Pow(x, 3)) - (900 * Math.Pow(x, 4)) + (400 * Math.Pow(x, 5)));
            //return (Math.Pow(x, 3)) + 2;
            //return ((1 / (x + 0.5)) + ((1 / 4) * Math.Pow(x, 2)));
            //return (Math.Log(1 + Math.Pow(x, 2)));
            //return (Math.Pow(Math.E, x)) * (1 - Math.Pow(0.5, 2));
            double div = (1 / 16);
            double div1 = (1 / 4);
            return ((((-3 / 4) * (Math.Pow(x, 2))) - x + 4) - ((div * Math.Pow(x, 4)) - (div1 * Math.Pow(x, 3))));
        }
        public double integral(double extremoizquierdo, double extremoderecho)
        {
            double h = (extremoderecho - extremoizquierdo) / 3;
            double x1 = h;
            double x2 = 2 * h;
            double tresoctavos = 0.375;
            double suma = (tresoctavos * (h)) * (f(extremoizquierdo) + (3 * f(x1)) + (3 * f(x2)) + f(extremoderecho));
            return suma;
        }
    }
}
