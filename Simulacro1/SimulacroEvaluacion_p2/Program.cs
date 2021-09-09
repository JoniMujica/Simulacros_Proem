using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulacroEvaluacion_p2
{
    /*
     * A una pareja se le pide los datos para mostrar un mensaje "
        ustedes se llaman xxxxx y xxxx pesan xx y xx kilos, que sumados
        son xx kilos y el promedio de peso xx ".
     */
    class Program
    {
        static void Main(string[] args)
        {
            string[] nombres = new string[2];
            double[] peso = new double[2];

            SolicitarDatos(ref nombres, ref peso);
            Imprimir(nombres, peso);
            Console.ReadKey();
        }
        static void SolicitarDatos(ref string [] nombre, ref double [] peso)
        {
            bool Cnv;
            for (int i = 0; i < nombre.Length; i++)
            {
                Console.WriteLine("Ingrese su nombre: ");
                nombre[i] = Console.ReadLine();
                do
                {
                    Console.WriteLine("Ingrese su peso: ");
                    Cnv = Double.TryParse(Console.ReadLine(), out peso[i]);

                    if (!Cnv || peso[i] < 0)
                    {
                        Console.WriteLine("ERROR: el dato del peso es invalido");
                    }

                } while (!Cnv || peso[i]<0);
            }
        }
        static void Imprimir(string [] nombres,double[] peso)
        {
            Console.WriteLine("Ustedes se llaman {0} y {1}", nombres[0], nombres[1]);
            Console.WriteLine("Pesan {0} y {1}", peso[0], peso[1]);
            Console.WriteLine("Que sumados son {0} Kilos", SumaPeso(peso));
            Console.WriteLine("Y el promedio de Peso {0}",PromedioPeso(peso));
                
        }
        static double SumaPeso(double[] peso) {
            double x = 0;
            for (int i = 0; i < peso.Length; i++)
            {
                x += peso[i];
            }
            return x;
        }
        static double PromedioPeso(double [] peso)
        {
            return (SumaPeso(peso) / peso.Count());
        }
    }
}
