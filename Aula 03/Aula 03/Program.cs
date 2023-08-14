using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, resultado;

            Console.Write(" \n Digite um número: ");
            a = int.Parse(Console.ReadLine());

            resultado = Math.Pow(a, 2);

            Console.Write("O Resultado é igual a: " + resultado);
            b = int.Parse(Console.ReadLine());

            resultado = Math.Sqrt(b);
            Console.Write("O Resultado é igual a: " + resultado);












































            Console.ReadKey();
        }
    }
}
