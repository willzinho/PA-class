using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_7
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exercicio 7 - Lista 1 - Escreva um algoritmo que calcule o total de moedas existentes em um 
            // cofrinho. O usuário deverá informar a quantidade de moedas de 1,00 real, 0,50, 0,25, 0,10, 0,05.
            // O algoritmo deve calcular o total em dinheiro acumulado.
            Double m1, m50, m25, m10, m5, tt;
            Console.WriteLine("quantas moedas de 1 real você tem ?");
            m1 = Double.Parse(Console.ReadLine());
            Console.WriteLine("quantas moedas de 0,50 centavos você tem ?");
            m50 = Double.Parse(Console.ReadLine());
            Console.WriteLine("quantas moedas de 0,25 centavos você tem ?");
            m25 = Double.Parse(Console.ReadLine());
            Console.WriteLine("quantas moedas de 0,10 centavos você tem ?");
            m10 = Double.Parse(Console.ReadLine());
            Console.WriteLine("quantas moedas de 0,05 centavos você tem ?");
            m5 = Double.Parse(Console.ReadLine());
            m1 = m1 * 1.00;
            m50 = m50 * 0.50;
            m25 = m25 * 0.25;
            m10 = m10 * 0.10;
            m5 = m5 * 0.05;
            tt = m1 + m50 + m25 + m10 + m5;
            Console.Write("o valor total de moedas é de : " + tt.ToString("R$###,##0.00"));
            Console.Read();
        }
    }
}
