using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notas_ABCDEF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float nota;

            Console.WriteLine("Qual sua nota de 0 a 10: ");
            nota = float.Parse(Console.ReadLine());

            if (nota == 1)
            {
                Console.WriteLine("Nota F");
            }
            else if (nota <= 3)
            {
                Console.WriteLine("Nota D");
            } else if (nota <=6)
            {
                Console.WriteLine("Nota C");
            } else if (nota <=8)
            {
                Console.WriteLine("Nota B");
            } else if (nota <= 9)
            {
                Console.WriteLine("Nota A");
            } else if (nota <= 10)
            {
                Console.WriteLine("Nota A+");

                Console.ReadKey();
            }
        } 
    }
}
