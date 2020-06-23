using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
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
            dynamic num1 = 4, num2 = 2;
            string operacion;
            Console.WriteLine("Digite el primer numero  ");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite segundo numero ");
            num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Escriba que operacion decea realizar, suma, resta, multiplicacion ");
            operacion = Console.ReadLine();

            if (operacion == "suma")
            {
                Console.WriteLine("El resultado de la suma es: " + (num1 + num2));
            } else if(operacion == "resta")
            {
                Console.WriteLine("El resultado de la suma es: " + (num1 - num2));
            }
            else if (operacion == "multiplicacion")
            {
                Console.WriteLine("El resultado de la multiplicacion es: " + (num1 * num2));
            }

            Console.ReadKey();
        }
    }
}
