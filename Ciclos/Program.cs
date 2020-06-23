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

            //int num = 0;
            /* while(num < 10)
             {
                 Console.WriteLine("Hola mundo");
                 num++;
             }
             */

            //do while  -has mientras
            /*do
            {
                Console.WriteLine("Hola mundo con do while \n");
                num++;

            } while (num < 10);*/

            //ciclo for - para
            /*for(int i = 0; i < 5; i++)
            {
                Console.WriteLine("Hola mundo con for \n");
            }
           */

            dynamic valor, suma=0, promedio;
            //ejercicio
            int i;
            for (i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingresa el numero "+ i +" por favor.\n");
                valor = Convert.ToDouble(Console.ReadLine());
                suma = suma + valor;
                      
            }

            promedio = suma / 5;

            Console.WriteLine("El resultado de la suma es: " + suma);
            Console.WriteLine("El resultado del promedio es: " + promedio);


            Console.ReadKey();


        }
    }
}
