using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sl1;
            int c;
            double resultado;
            double multi = 1.8;
            int f = 32;


            Console.WriteLine("Converitire tus centigrados a farenheit. Dime tus centigrados; ");
            sl1 = Console.ReadLine();
            c = Convert.ToInt32(sl1);
            resultado = c * multi + f;

            Console.WriteLine("tus farenheit son: {0}", resultado);
            Console.ReadLine();
        }
    }
}
