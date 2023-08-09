using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_01._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Hello World"); // Console.Write para termos mais interações com o console e Write serve para escrever no console 
            //Console.ReadKey(); // ReadKey Le somente uma tecla
            //string (cadeia)
            // int (inteiro)
            //flowt (real)

            int numero1;
            int numero2;
            int numero3;
            int numero4;
            int soma;

            Console.Write("Digite o primeiro numero:");
            //int.Parse converte uma cadeia de caracter para o tipo INTEIRO
            numero1 = int.Parse (Console.ReadLine()); // Le a sequencia do carater digitado pelo usuario
            // Estamos utilizando o sinal de + para concatenar o texto digitado + o valor da variavel "numero1"
            Console.WriteLine("O Valor digitado foi:  " + numero1);

            Console.Write("Digite o segundo numero: ");
            numero2 = int.Parse(Console.ReadLine());

               
            Console.WriteLine("O Valor do Segundo Numero foi: " + numero2);

            Console.Write("Digite o Terceiro Numero:");

            numero3 = int.Parse(Console.ReadLine());

            Console.WriteLine("O Valor do Terceiro Numero foi: " + numero3);

            Console.Write("Digite o Quarto Numero: ");

            numero4 = int.Parse(Console.ReadLine());

            Console.WriteLine("O Valor do Quarto Numero foi " + numero4);

            soma = numero1 + numero2 + numero3 + numero4;

            Console.WriteLine("O Valor total foi:" + soma);




            Console.ReadKey(); // Nesse momento o ReadKey serve para o nosso programa não fechar

            
        }
    }
}
