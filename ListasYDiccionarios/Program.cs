using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasYDiccionarios
{
    class Program
    {
        static void Main(string[] args)
        {
            //listas (indice, valor)y diccionarios(clave, valor )
            List<int> listanumeros = new List<int>();

            listanumeros.Add(15);
            listanumeros.Add(40);
            listanumeros.Add(39);
            listanumeros.Add(12);

            //insertar elementos a la lista en una posicion concreta
            listanumeros.Insert(2, 76);

            //da la vuelta a la lista
            listanumeros.Reverse();

            //para saber si contiene o no un elemto dado
            if (listanumeros.Contains(40))
            {
                Console.WriteLine("Si contiene el elemento 40");
            }
           
            //recorrer una lista con el for tenemos accesso al numero de elementos
            /*
             * for(int i = 0; i < listanumeros.Count; i++)
            {
                Console.WriteLine(listanumeros[i]);
            }
            */


            /*imprimiendo la lista, dentro de un foreach no podemos ni modificar la lista, 
            ni añadirle cosas, ni eliminar*/
            foreach (int numero in listanumeros)
            {
                Console.WriteLine(numero);
                //nos dira la posicion de cada elemento
                Console.WriteLine("Posicion "+listanumeros.IndexOf(numero));
            }

            int suma = 0;
            foreach (int numero in listanumeros)
            {
                suma = suma + numero;
                
            }
            Console.WriteLine("La suma de todos los numeros es: " +suma);

            //diccionarios (claves, valor) instanciacion
            Dictionary<string, string> alumnos = new Dictionary<string, string>();

            //añadir elementos al diccionario
            alumnos.Add("a", "Paula");
            alumnos.Add("b", "Antonio");
            alumnos.Add("c", "Fra");
            alumnos.Add("d", "Sergi");
            alumnos.Add("e", "Nelsy");

            //imprimir 
            Console.WriteLine(alumnos["a"]);

            //eliminar eleemnto de diccionario
            alumnos.Remove("a");

            //recorrer
            /*foreach (KeyValuePair<string, string> elemento in alumnos)
            {
                Console.WriteLine("Clave " + elemento.Key + ":" + elemento.Value);
            }*/

            //para reducir lo anterior tambien se puede hacer esto:
            foreach (var elemento in alumnos)
            {
                Console.WriteLine("Clave " + elemento.Key + ":" + elemento.Value);
            }

            Console.ReadKey();
        }
    }
}
