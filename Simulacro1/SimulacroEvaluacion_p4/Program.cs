using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulacroEvaluacion_p4
{
    class Program
    {
        /*
            (IF).Pedir dos números y mostrar el resultado:
            a. Si son iguales los muestro concatenados.
            b. Si el primero es mayor, los resto,
            c. de lo contrario los sumo.
            d. Si la resta es mayor a 10 ,además de mostrar el resultado,
            muestro el mensaje "la resta es xxx y superó el 10".
         
         */
        static void Main(string[] args)
        {
            bool valido = false;
            double a, b;
            do
            {
                Console.WriteLine("Ingrese el primer numero: ");
                valido = Double.TryParse(Console.ReadLine(), out a);

                Console.WriteLine("Ingrese el segundo: ");
                valido = Double.TryParse(Console.ReadLine(), out b);

                if (!valido)
                {
                    Console.WriteLine("error:los datos son invalidos,ingrese un valor numerico");
                }
                else
                {
                    Evaluar(a, b);
                }
            } while (!valido);

            Console.ReadKey();
        }

        static void Evaluar(double num1, double num2) {
            if (num1 == num2)
            {
                Console.WriteLine("{0}{1}", num1, num2);
            }
            else if ((num1-num2) > 10)
            {
                Console.WriteLine("La resta es {0} y supero el 10",  (num1-num2));
            }
            else if (num1 > num2)
            {
                num1 -= num2;
            }
            else if (num2 > num1)
            {
                num1 += num2;
            }
        }
    }
}
