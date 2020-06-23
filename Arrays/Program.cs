using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //Arrays

            //declaraciones de arrays
            //int[] numeros = new int[5];

            //otra declaracion si sabemos que datos va tener mi array
            int[] numeros = { 3, 13, 33, 83, 123};

            //cambiar cualquiera de esos datos
            numeros[3] = 35;


            //acceder a posiciones del array
            /* numeros[0] = 3;
             numeros[1] = 13;
             numeros[2] = 33;
             numeros[3] = 83;
             numeros[4] = 123;*/

            /*si lo que queremos hacer es agrandar el array pues lo que podemos hacer es 
            hacer otro array mas grande y añadirle los datos del anterior*/
            int[] numeros2 = new int[10];

            //recorrer un array
            for (int i = 0; i < numeros.Length; i++)
            {
                //copio los datos del array de arriba en el nuevo
                numeros2[i] = numeros[i];
                Console.WriteLine("El elemento " + (i + 1) + " es igual a " + numeros2[i]);
            }

            Console.WriteLine("****************************");

            //recorrer un array
            for (int i = 0; i < numeros2.Length; i++)
            {
                Console.WriteLine("El elemento " + (i + 1) + " es igual a " + numeros2[i]);
            }

            Console.ReadKey();
        }
    }
}
