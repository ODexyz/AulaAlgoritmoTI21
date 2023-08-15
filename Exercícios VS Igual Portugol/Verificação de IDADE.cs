using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verificar_Idade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float valor;

            Console.WriteLine("Qual a sua idade?");
            valor = float.Parse(Console.ReadLine());

            if (valor >=18)
            {
                Console.WriteLine("Maior de Idade!");
            }
            if (valor < 18)
            {
                Console.WriteLine("Menor de idade");
            }
        }
    }
}
