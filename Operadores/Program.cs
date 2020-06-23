using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operadores
{
    class Program
    {
        static void Main(string[] args)
        {
            //Operadores Relacionales
            //mayor >
            //menor <
            //menor igual <= mayor igual >=
            //comparacion de igualdad ==
            //diferencia !=

            //Operadores logico
            //and && si las dos condiciones son verdaderas
            //Or || si almenos una es verdadera pues cumple la condicion

            double peso;
            byte edad;

            Console.WriteLine("Digita tu peso: ");
            peso = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digita tu edad: ");
            edad = Convert.ToByte(Console.ReadLine());

            //limpiar pantalla
            Console.Clear();

            //estructura de control 
            if (peso > 100 && edad >= 15)
            {
                //imprime en pantalla
                Console.WriteLine("Tu peso es normal");

            }

            //para detener la aplicacion 
            Console.ReadKey();
        }
    }
}
