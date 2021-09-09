using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulacroEvaluacion
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] valores = new double[3];

            bool igual = false;
            do
            {
                SolicitarValores(ref valores);
                if (!SonIguales(valores))
                {
                    Console.WriteLine("ERROR: ingrese numeros iguales mayor a 0: ");
                }
            } while (!SonIguales(valores));
            
            if(SonIguales(valores))


            {
                double perimetro = Perimetro(valores);
                Console.WriteLine("El perimetro es: {0}" , perimetro);
            }
            Console.ReadKey();
        }

        static void SolicitarValores(ref double [] vec)
        {
            for (int i = 0; i < vec.Length; i++)
            {
                Console.WriteLine("Digite un numero: ");
                while (!Double.TryParse(Console.ReadLine(), out vec[i]))
                {
                    Console.WriteLine("ERROR: el digito ingresado es invalido, por favor ingrese un valor numerico: ");
                }
                Console.WriteLine("pos {0}", i);
            }
        }
        static bool SonIguales(double [] vec)
        {
            for (int i = 1; i < vec.Length-1; i++)
            {
                if (vec[i] == vec[i-1])
                {
                    return true;
                    break;
                }
            }
            return false;
        }
        static double Perimetro(double[] vec) {
            double sumador = 0;
            for (int i = 0; i < vec.Length; i++)
            {
                sumador += vec[i];

            }
            return sumador;
        }
    }
}
