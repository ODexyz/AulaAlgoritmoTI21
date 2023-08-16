using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_IMC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu peso em kg:");
            double peso = double.Parse(Console.ReadLine());



            Console.WriteLine("Digite sua altura em metros:");
            double altura = double.Parse(Console.ReadLine());



            double imc = peso / (altura * altura);



            Console.WriteLine("Seu IMC é " + imc);



            if (imc < 18.5)
            {
                Console.WriteLine("Abaixo do peso");
            }
            else if (imc < 25)
            {
                Console.WriteLine("Peso normal");
            }
            else if (imc < 30)
            {
                Console.WriteLine("Sobrepeso");
            }
            else if (imc < 35)
            {
                Console.WriteLine("Obesidade grau I");
            }
            else if (imc < 40)
            {
                Console.WriteLine("Obesidade grau II");
            }
            else
            {
                Console.WriteLine("Obesidade grau III");
            }
            Console.ReadKey();























            Console.ReadKey();
        }
    }
}
