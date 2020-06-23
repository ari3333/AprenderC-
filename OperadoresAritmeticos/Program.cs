using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperadoresAritmeticos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Operadores aritmeticos

            //suma + 
            //resta -
            //multiplicacion *
            //division /
            //residuo %
            //int num = 4, num1 = 2;

            double num, pot, resultado;

          

            //Console.WriteLine("El resultado de la suma es: " + (num + num1));
            //Console.ReadKey();

            /* 
             *  para calcular la potencia tenemos una clase que es la mat y posee una serie de metodos 
             *  para hacer varias cosas ej:
             */
            /**/
            Console.WriteLine("Digite el numero que quiere elevar ");
            num = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a la potencia que quiere elevar ");
            pot = Convert.ToDouble(Console.ReadLine());

            //potencia
            pot = Math.Pow(num, pot);

            //escribirlo por pantalla
            Console.WriteLine("El resultado es: "+ pot);

            //raiz cuadrada
            //Console.WriteLine("La raiz cuadrada es: " + Math.Sqrt(49));

            Console.ReadKey();


        }
    }
}
