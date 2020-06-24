using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForEach
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] listaCompra = new string[4];
            int[] numeros = { 1, 3, 5, 7, 9 };

            listaCompra[0] = "Leche";
            listaCompra[1] = "Arroz";
            listaCompra[2] = "Pollo";
            listaCompra[3] = "Uevo";

            //foreach
            foreach(string elemento in listaCompra) //para cada elemento en lista de compra
            {
                Console.Write(elemento + ", ");
            }
            Console.WriteLine("\n ******************* ");

            int suma = 0;
            //foreach
            foreach (int elemento in numeros) //para cada elemento en lista de compra
            {
                suma = suma + elemento;
               
            }
            Console.WriteLine("La suma es: "+suma);

            //array multidimencionales
            int[,] numerosCuadrado = new int[2, 3];

            numerosCuadrado[0, 0] = 36;
            numerosCuadrado[0, 1] = 13;
            numerosCuadrado[0, 2] = 93;
            numerosCuadrado[1, 0] = 366;
            numerosCuadrado[1, 1] = 13;
            numerosCuadrado[1, 2] = 23;

            Console.WriteLine("\n ******************* ");

            Console.WriteLine(numerosCuadrado[1, 1]);

            Console.ReadKey();
        }
    }
}
