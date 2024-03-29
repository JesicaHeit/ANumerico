﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class NewtonRaphson
    {
        public static double f(double x)
        {
            //return Math.Log(x) + (1 / x) - 3;
            //return ((12.5 * (x + 2)) / (Math.Pow(x, 2) + 4 * x + 5)) + 2;
            //return Math.Abs(Math.Pow(x, 2) - 4) + 2 * x;
            return (((10 * x + 20) / (x * x + 4 * x + 5)) + 2);

        }

        public Salida NRaphson(double xi)
        {
            double c = 0;
            var itermax = 100;
            double error = 0;
            double derivada;
            double xr = 0;
            double xant = 0;
            double tolerancia = 0.0001;

            Salida salida = new Salida();

            if (f(xi) == 0)
            {
                salida.ErrorRelativo = 0;
                salida.Raiz = xi;
                salida.NroIteraciones = c;

            }
            else
            {
                xant = 0;

                do
                {
                    derivada = (((f(xi + tolerancia) - f(xi))) / tolerancia);
                    xr = xi - (f(xi) / derivada);
                    error = Math.Abs((xr - xant) / xr);

                    c=c+1;
                    xi = xr;
                    xant = xr;

                } while ((Math.Abs(f(xr)) > tolerancia) && (c < itermax));

                salida.Raiz = xr;
                salida.NroIteraciones = c;
                salida.ErrorRelativo = error;

            }

            return salida;

        }
    }
}

