using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            //listas sustitutos de los arrays
            List<int> listaNumeros = new List<int>();

            //añadir elementos a la lista
            listaNumeros.Add(15);
            listaNumeros.Add(154);
            listaNumeros.Add(34);
            listaNumeros.Add(43);

            //imprimir elementos
            //Console.WriteLine(listaNumeros[0]);

            //como saber el numero de elementos de la lista
            //Console.WriteLine("Numeros de lementos que tiene la lista: "+ listaNumeros.Count); 

            //eliminar elementos de la lista, si existen dos iguales elimina solo el primero de ellos
            listaNumeros.Remove(154);

            //eliminar elementos en una posicion concreta
            listaNumeros.RemoveAt(1);

            //eliminar todos los elementos
            listaNumeros.Clear();

            //recorriendo la lista
            foreach (int numero in listaNumeros)
            {
                Console.WriteLine(numero);
            }
            Console.ReadKey();
        }
    }
}
