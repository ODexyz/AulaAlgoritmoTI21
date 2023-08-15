using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Par_ou_Ímpar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número: ");

            int num = int.Parse(Console.ReadLine());

            if (num %2 == 0)
            {
                Console.WriteLine("PAR");
            }
            else
            {
                Console.WriteLine("ÍMPAR");
            }

            Console.WriteLine("/n Pressione qualquer tecla para sair...");

            Console.ReadKey();

        }
    }
}
