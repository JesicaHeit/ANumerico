using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class GaussSeidel
    {
        public double tolerancia { get; set; }
        public int maximoIteraciones { get; set; }
        public int iteracionesUtilizadas { get; set; }
        public int cantidadElementos { get; set; }
        public bool diagDominante { get; set; }

        public GaussSeidel()
        {

        }

        public double[] MGaussSeidel(double[,] Mmatriz)
        {
            tolerancia = 0.0001;
            maximoIteraciones = 100;

            double x = 0;
            int contador = 0;
            double resultado = 0;

            double[] Vector = new double[cantidadElementos];
            double[] vectorAnterior = new double[cantidadElementos];
            double[] vectorResultado = new double[cantidadElementos];

            bool freno = true;
            diagDominante = true;

            while (freno == true & maximoIteraciones >= contador)
            {
                contador = contador + 1;
                if (contador > 1)
                    Vector.CopyTo(vectorAnterior, 0);
                for (int i = 0; i < cantidadElementos; i++)
                {
                    resultado = Mmatriz[i, cantidadElementos];
                    x = Convert.ToDouble(Mmatriz[i, i]);
                    for (int j = 0; j < cantidadElementos; j++)
                    {
                        if (i != j)
                            resultado = resultado - (Mmatriz[i, j] * Vector[j]);
                    }
                    x = Convert.ToDouble(resultado) / x;
                    Vector[i] = x;
                }
                freno = false;
                for (int i = 0; i < cantidadElementos; i++)
                {
                    vectorResultado[i] = Math.Abs(Vector[i] - vectorAnterior[i]);
                    if (vectorResultado[i] > tolerancia)
                        freno = true;
                }
            }
            iteracionesUtilizadas = contador;
            return Vector;
        }

        //for (int i = 0; i < cantidadElementos; i++) 
        //{
        //    double diagonal = Mmatriz[i, i];
        //    double sumatoria = 0;
        //    for (int j = 0; j < cantidadElementos; j++)  
        //    {
        //        if (i != j)
        //            sumatoria = sumatoria + Math.Abs(Mmatriz[i, j]);
        //    }
        //    if (Math.Abs(diagonal) < sumatoria)
        //    {
        //        diagDominante = false;
        //        break;
        //    }

        //}
    }
}

