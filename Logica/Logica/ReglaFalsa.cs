﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class ReglaFalsa
    {
        public static double f(double x)
        {
            //double e = 2.71828;
            //return ((x * x * x * x * x - 1) * (x*x) - 10);
            //return ((12.5 * (x + 2)) / (Math.Pow(x, 2) + 4 * x + 5)) + 2;
            //return ((Math.Pow(x,2) - 3*x + Math.Log(1 + x))-(5 - Math.Sqrt(x)));
            return (((10 * x + 20) / (x * x + 4 * x + 5)) + 2);

        }
        public Salida MReglaFalsa(double extremoizquierdo, double extremoderecho)
        {
            Salida salida = new Salida();
            double xr = 0;
            int contador = 0;
            double Xant = 0;
            double Error = 0;
            int Iteraciones = 100;
            double Tolerancia = 0.0001;
            double resultado = 0;
            resultado = f(extremoizquierdo) * f(extremoderecho);
            if (resultado > 0)
            {
                salida.ErrorMsje = ("f(x1)*f(x2) > 0");
            }
            if (resultado == 0)
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
            if (resultado < 0)
            {

                do
                {
                    xr = (((f(extremoizquierdo) * extremoderecho) - (f(extremoderecho) * extremoizquierdo))) / (f(extremoizquierdo) - f(extremoderecho));
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

