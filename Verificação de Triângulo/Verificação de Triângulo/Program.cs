using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verificação_de_Triângulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;

            Console.WriteLine("Digite o primeiro lado do Triângulo: ");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo lado do Triângulo");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o terceiro lado do Triângulo");
            c = int.Parse(Console.ReadLine());

            if (a == b) { }
        }
    }
}
