using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ano_Bissexto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float ano;

            Console.WriteLine("Selecione um Ano");

            ano = float.Parse(Console.ReadLine());

            if (ano % 4 == 0)
            {
                if (ano % 100 != 0)
                {

                    Console.WriteLine("Bissexto");
                }
            }
            else
            {
                Console.WriteLine("Não é Bissexto!");
            }
    













                Console.ReadKey();
            }
        }
    }
