using System;

namespace Tp02Ejercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Resolución de una ecuación cuadrática";
            int a, b, c;
            double discriminante;
            Console.Write("Ingrese el valor del coeficiente cuadrático:");
            if (int.TryParse(Console.ReadLine(),out a))
            {
                Console.Write("Ingrese el valor del coeficiente lineal:");
                if (int.TryParse(Console.ReadLine(),out b))
                {
                    Console.Write("Ingrese el valor del coeficiente independiente:");
                    if (int.TryParse(Console.ReadLine(),out c))
                    {
                        discriminante = CalcularDiscriminante(a, b, c);
                        if (discriminante==0)
                        {
                            double raizUnica = CalcularRaizUnica(a,b);
                            Console.WriteLine($"La ecuación tiene una solución y es {raizUnica}");
                        }else if (discriminante>0)
                        {
                            CalcularSoluciones(a, b, discriminante);
                        }
                        else
                        {
                            CalcularSolucionesImaginarias(a, b, discriminante);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Coef. independiente no válido");
                    }
                }
                else
                {
                    Console.WriteLine("Coef lineal no válido");
                }
            }
            else
            {
                Console.WriteLine("Coef. cuadrático no válido");
            }
            Console.ReadLine();
        }

        private static void CalcularSolucionesImaginarias(int a1, int b1, double discriminante)
        {
            var parteReal = -b1 / 2 * a1;
            var parteImaginaria = Math.Sqrt(Math.Abs(discriminante)) / 2 * a1;
            Console.WriteLine("Solución en el campo de los números imaginarios");
            Console.WriteLine($"Raiz 1={parteReal}+{parteImaginaria}i");
            Console.WriteLine($"Raiz2={parteReal}-{parteImaginaria}i");

        }

        private static void CalcularSoluciones(int a1, int b1, double discriminante)
        {
            var raiz1 = (-b1 + Math.Sqrt(discriminante)) / 2 * a1;
            var raiz2 = (-b1 - Math.Sqrt(discriminante)) / 2 * a1;
            Console.WriteLine("Solución 2 raices");
            Console.WriteLine($"Raiz 1={raiz1}");
            Console.WriteLine($"Raiz2={raiz2}");
        }

        private static double CalcularRaizUnica(int a, int b)
        {
            return -b / (2 * a);
        }

        private static double CalcularDiscriminante(int a, int b, int c)
        {
            return Math.Pow(b, 2) - 4 * a * c;
        }
    }
}
