using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            float pagamento, valor, troco;
            int menu;


            Console.WriteLine("Menu");
            Console.WriteLine("1 - Média de 3 Números");
            Console.WriteLine("2 - Troco de Compra");
            Console.WriteLine("3 - Conversão de Temperatura");
            Console.WriteLine("Escolha a Opção: ");
            menu = int.Parse(Console.ReadLine());

            if (menu == 1)
            {
                float a, b, c;
                float soma, media;

                Console.WriteLine("Digite o 1° número");
                a = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o 2° Número");
                b = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o 3° Número");
                c = int.Parse(Console.ReadLine());

                soma = a + b + c;
                media = soma / 3;

                Console.WriteLine("O Valor da média é:" + media);

            }
            else if (menu == 2)
            {
                Console.WriteLine("Digite o valor total da compra: ");
                valor = float.Parse(Console.ReadLine());

                Console.WriteLine("Digite o valor pelo cliente: ");
                pagamento = float.Parse(Console.ReadLine());

                if (valor > pagamento)
                {
                    Console.WriteLine("O valor do pagamento é insuficiente para concluir a compra! CALOTEIRO ");
                }
                else
                {
                    troco = pagamento - valor;
                    Console.WriteLine(" O Valor do seu troco é: R$ " + troco);

                } 

            } else
            {
                float celsius, fahrenheit;

                Console.WriteLine("Digite a temperatura em Celsius");
                celsius = float.Parse(Console.ReadLine());

                fahrenheit = celsius = 9 / 5 + 32;
                Console.WriteLine("A temperatura em Fahrenheit é:" + fahrenheit);
            }














            Console.ReadKey();
        }
    }
}
