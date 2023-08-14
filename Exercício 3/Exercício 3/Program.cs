using System;
using System.Collections.Generic;
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

            Console.WriteLine("Digite o valor total da compra: ");
            valor = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor pelo CLIENTE: ");
            pagamento = float.Parse(Console.ReadLine());
            
            troco = pagamento - valor;

            Console.WriteLine("O Valor do seu troco é: " + troco);
















            Console.ReadKey();
        }
    }
}
