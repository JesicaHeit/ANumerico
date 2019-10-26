using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Biseccion
    {
        public static double f(double x)
        {
            //double e = 2.71828;
            //return ((x * x * x * x * x - 1) * (Math.Exp(x)) - 10);
            //return ((12.5 * (x + 2)) / (Math.Pow(x, 2) + 4 * x + 5)) + 2;
            //return (((10 * x + 20) / (x * x + 4 * x + 5)) + 2);
            return ((1.20*x + 13.82) - (-0.94*x + 32.63));
            //return Math.Abs(Math.Pow(x,2) - 4) + 2 * x;
        }
        public Salida MBiseccion(double extremoizquierdo, double extremoderecho)
        {
            Salida salida = new Salida();
            double xr = 0;
            int contador = 0;
            double Xant = 0;
            double Error = 0;
            int Iteraciones = 100;
            double Tolerancia = 0.0001;
            if (f(extremoizquierdo) * f(extremoderecho) > 0)
            {
                salida.ErrorMsje = ("f(x1)*f(x2) > 0");
            }
            else if (f(extremoizquierdo) * f(extremoderecho) == 0)
            {
                if (f(extremoizquierdo) == 0)
                {
                    salida.ErrorMsje = ("El extremo izquierdo es la raiz");
                    salida.ErrorRelativo = 0;
                    salida.NroIteraciones = contador;
                }
                else if (f(extremoderecho) == 0)
                {
                    salida.ErrorMsje = ("El extremo derecho es la raiz");
                    salida.ErrorRelativo = 0;
                    salida.NroIteraciones = contador;
                }
            }
            else
            {

                do
                {
                    xr = (extremoizquierdo + extremoderecho) / 2;
                    contador = contador + 1;
                    Error = Math.Abs((xr - Xant) / xr);

                    if (Math.Abs(f(xr)) < Tolerancia | contador > Iteraciones | Error < Tolerancia)
                    {
                        salida.Raiz = xr;
                        salida.ErrorRelativo = Error;
                        salida.NroIteraciones = contador;
                    }
                    else if (f(extremoizquierdo) * f(extremoderecho) < 0)
                    {
                        extremoizquierdo = xr;
                    }
                    else
                    {
                        extremoderecho = xr;
                    }
                    Xant = xr;
                } while (Error > Tolerancia && contador <= Iteraciones);
            }
            return salida;
        }
    }
}
