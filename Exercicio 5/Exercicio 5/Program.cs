using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exercicio 5 - Lista 1 - Faça um algoritmo que leia os valores de COMPRIMENTO, LARGURA e ALTURA e 
            // apresente o valor do volume de uma caixa retangular. Utilize para o cálculo a fórmula 
            // VOLUME = COMPRIMENTO * LARGURA * ALTURA.
            float comp, larg, alt, vol;
            Console.Write("digite o comprimento :");
            comp = float.Parse(Console.ReadLine());
            Console.Write("digite o largura :");
            larg = float.Parse(Console.ReadLine());
            Console.Write("digite o altura :");
            alt = float.Parse(Console.ReadLine());
            vol = comp * larg * alt;
            Console.Write("O volume da caixa é : " + vol.ToString("#,##0.00"));
            Console.Read();
        }
    }
}
