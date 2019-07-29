using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_9
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exercicio 9 - Lista 1 - Faça um algoritmo que leia a idade de uma pessoa expressa em anos, 
            // meses e dias e escreva a idade dessa pessoa expressa apenas em dias. Considerar ano com 365 dias
            //  e mês com 30 dias.
            int ano, mes, dia, tt_dias;
            Console.Write("Quantos anos você tem ?");
            ano = int.Parse(Console.ReadLine());
            Console.Write("Quantos meses você tem ?");
            mes = int.Parse(Console.ReadLine());
            Console.Write("Quantos dias você tem ?");
            dia = int.Parse(Console.ReadLine());
            tt_dias = (ano * 365) + (mes * 30) + dia;
            Console.WriteLine("Você tem o total de " + tt_dias + " dias de vida , Parabens!!!! ");
            Console.Read();

        }
    }
}
