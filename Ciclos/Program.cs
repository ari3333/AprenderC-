using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ciclos
{
    class Program
    {
        static void Main(string[] args)
        {
            //ciclos (bloque de codigo que se ejecuta un determinado numero de veces)
            //while, do while, for, foreach

            //incrementos ++ y decrementos --

            int num = 0;
            /* while(num < 10)
             {
                 Console.WriteLine("Hola mundo");
                 num++;
             }
             */

            //do while  -has mientras
            do
            {
                Console.WriteLine("Hola mundo con do while \n");
                num++;

            } while (num < 10);
            Console.ReadKey();



            
        }
    }
}
