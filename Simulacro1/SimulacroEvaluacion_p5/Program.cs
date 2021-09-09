using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulacroEvaluacion_p5
{
    class Program
    {
        /*
            (SOLO WITCH). Una empresa de viajes le solicita ingresar que
            continente le gustaría visitar y la cantidad de días , la oferta dice
            que por día se cobra $100 , que se puede pagar de todas las
            maneras:
            a. Si es América tiene un 50% de descuento y si además paga
            por débito se le agrega un 10% más de descuento
            b. Si es África tiene un 60% de descuento y si además paga
            por mercadoPago o efectivo se le agrega un 15% mas de
            descuento
            c. Si es Europa tiene un 20% de descuento y si ademas paga
            por débito se le agrega un 15% , por mercadoPago un 10%
            y cualquier otro medio 5%
            d. cualquier otro continente tiene un recargo del 20%         
         */
        static int dias;
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la cantidad de dias:");
            dias = Int32.Parse(Console.ReadLine()) * 100;  
            string[] Continentes = new string[] { "America", "Africa", "Europa", "Otros" };
            string[] Pagos = new string[] { "Debido", "Mercado Pago", "Efectivo", "Otros" };
            int opcionCont = Menu(Continentes);
            int opcionPago = Menu(Pagos);
            double res = OperarCasos(opcionCont, opcionPago);

            Console.WriteLine("El monto total a pagar por {0} dias es: {1}", dias/100 ,res); ;
            Console.ReadKey();
        }

        static int Menu(string[] Lista)
        {
            Console.Clear();
            Console.WriteLine("*****************************");
            //Console.WriteLine("Seleccione el destino que desea viajar ");
            Console.WriteLine("{0}", (Lista[0] == "America") ? "Seleccione el destino que desea viajar" : "Seleccione el metodo de pago");
            Console.WriteLine("*****************************");
            for (int i = 0; i < Lista.Length; i++)
            {
                Console.WriteLine("{0} - {1}", (i + 1), Lista[i]);
            }

            int op = 0;
            bool pudoConvertir = Int32.TryParse(Console.ReadLine(), out op);
            if (pudoConvertir == false || op >= Lista.Length)
            {
                op = 0;
            }
            return (op - 1);
        }

        static double OperarCasos(int opcionCont, int opcionPago)
        {
            switch (opcionCont)
            {
                case 0:
                    switch (opcionPago)
                    {
                        case 0:
                            return dias - 0.5 * dias - 0.10*dias;
                        default:
                            return dias - 0.5 * dias;
                    }
                case 1:
                    switch (opcionPago)
                    {
                        case 1:
                        case 2:
                            return dias - 0.6 * dias - 0.15 * dias;
                        default:
                            return dias - 0.6 * dias;
                    }
                case 2:
                    switch (opcionPago)
                    {
                        case 0:
                            return dias - 0.20 * dias - 0.15 * dias;
                        case 1:
                            return dias - 0.20 * dias - 0.10 * dias;
                        default:
                            return dias - 0.20 * dias - 0.05 * dias;
                    }        
            }
            return dias + 0.20 * dias;
        }
    }
}
