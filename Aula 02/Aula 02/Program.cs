using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float a;
            float b;
            float soma;
            float subtracao;
            float multiplicacao;
            float divisao;
            float resto;

            //Console.Write("Hello World");

            Console.Write("Digite o 1° numero: ");
            a = int.Parse( Console.ReadLine() );

            Console.Write("Digite o 2° numero: ");
            b = int.Parse( Console.ReadLine() );


            soma = a + b; // Estamos somando os valores das variáveis A e B

            Console.WriteLine("A Soma Dos Valores: " + soma);

            subtracao = a - b; // Estamos subtraindo os valores das variáveis A e B

            Console.WriteLine("A Subtração dos Valores: " + subtracao);

            multiplicacao = a * b;

            Console.WriteLine("A Multiplicação dos Valores: " + multiplicacao);

            divisao = a / b;

            Console.WriteLine("A Divisão dos Valores: " + divisao);





            Console.ReadKey();
        }
    }
}
