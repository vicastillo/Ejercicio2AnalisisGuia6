using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2AnalisisGuia6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.Title = "Programa para encontrar cuadrante";
            Console.WriteLine("Bienvenido a su programa para identificar en qué cuadrante se encuentra el par digitado.");
            Console.WriteLine("Ingrese los pares ordenados de la forma (x, y).");
            String i;
            String[] arr = { };
            Double par1 = 0, par2 = 0;
            int flag = 0;

            do {

                Console.WriteLine(" ");
                i = Console.ReadLine();
                arr = i.Trim(' ', '(', ')').Split(',');
                par1 = Double.Parse(arr[0]);
                par2 = Double.Parse(arr[1]);
           

                if (par1 < 0)
                {
                    if (par2 > 0)
                    {
                        Console.WriteLine("El par está en el segundo cuadrante. Digite el siguiente par a identificar: ");

                    }
                    if (par2 < 0)
                    {
                        Console.WriteLine("El par está en el tercer cuadrante. Digite el siguiente par a identificar: ");

                    }

                }

                if (par1 > 0)
                {
                    if (par2 > 0)
                    {
                        Console.WriteLine("El par está en el primer cuadrante. Digite el siguiente par a identificar: ");

                    }
                    if (par2 < 0)
                    {
                        Console.WriteLine("El par está en el cuarto cuadrante. Digite el siguiente par a identificar: ");

                    }
                }


            }

            while (flag == 0);
            Console.ReadKey();

            }
    }
}
