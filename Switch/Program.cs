using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            //switch ejecuta distintas instrucciones dependiendo del valor de la variable

            int valor = 1;

            //variable a evaluar
            switch(valor)
            {
                case 1:
                    Console.WriteLine("Entro al case 1");
                    break;
                case 2:
                    Console.WriteLine("Entro al case 2");
                    break;
                case 3:
                    Console.WriteLine("Entro al case 3");
                    break;
                default:
                    Console.WriteLine("Entro al case default");
                    break;
            }
            //para parar el programa
            Console.ReadKey();


        }
    }
}
