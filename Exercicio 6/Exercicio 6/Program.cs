using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exercicio 6 - Lista 1 - Faça um programa que receba o valor do quilo de um produto e a quantidade 
            // de quilos do produto consumida calculando o valor final a ser pago.
            float valor_k, quant_k, valor_pg;
            Console.Write("Digite o valor do quilo :");
            valor_k = float.Parse(Console.ReadLine());
            Console.Write("Digite quantos quilos : ");
            quant_k = float.Parse(Console.ReadLine());
            valor_pg = valor_k * quant_k;
            Console.Write("Valor a ser pago :" + valor_pg.ToString("##,##0.00"));
            Console.Read();
        }
    }
}
