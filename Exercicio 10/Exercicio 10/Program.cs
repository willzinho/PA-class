using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_10
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exercicio 10 - Lista 1 - Escreva um algoritmo para ler uma temperatura em graus Fahrenheit, 
            // calcular e escrever o valor correspondente em graus Celsius (baseado na fórmula abaixo):
            //    C              F - 32
            //---------- = -----------
            //    5                 9

            float fah, cel;
            Console.Write("Informe a temperatura em fahrenheit : ");
            fah = float.Parse(Console.ReadLine());
            cel = ((fah - 32) / 9) * 5;
            Console.WriteLine("A temperatura em graus celsius é de " + cel.ToString("#0.0") + " graus");
            Console.Read();
        }
    }
}
