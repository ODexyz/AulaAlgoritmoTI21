using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int soma, div, resultado;
            int a, b, c;

            Console.WriteLine("Digite o primeiro número: ");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o terceiro número: ");
            c = int.Parse(Console.ReadLine());

            soma = a + b + c;

            Console.WriteLine("A Soma é: " + soma);

            div = soma / 3;

            Console.WriteLine("A Média Total é: " + div );

            soma = int.Parse(Console.ReadLine());
          
            Console.ReadKey();
        }
    }
}
