using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiposDatos
{
    class Program
    {
        static void Main(string[] args)
        {
            //tipo de datos byte de 0 a 255
            //byte variable = 230;

            //int desde -2147,483,648 al 2147,483,647
            //int variable = 2147483647;

            //double 
            //double variable = 56.78;

            //boolean true false
            //Boolean variable = true;

            //character acepta un caracter a la vez
            //char variable = 'C';

            //String
            //string variable = "cadena";

            //tipo de dato dynamic que es cuando no se conoce el tipo de dato que se va a ingresar
            dynamic variable = 23;

            Console.WriteLine("El valor de la variable es: " + variable);

            Console.ReadKey();
        }
    }
}
