using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_8
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exercicio 8 - Lista 1- Um motorista deseja colocar no seu tanque X reais	de gasolina.
            //  Escreva um	algoritmo para ler o preço do litro da gasolina e o valor	do pagamento,
            //  e exibir quantos litros ele conseguiu colocar  no  tanque.
            Double x_reais, prec_lit, quant_lit;
            Console.WriteLine("quantos reais de combustive ?");
            x_reais = double.Parse(Console.ReadLine());
            Console.WriteLine("Qual o valor do litro do combustive ?");
            prec_lit = double.Parse(Console.ReadLine());
            quant_lit = x_reais / prec_lit;
            Console.WriteLine("Você colocou  " + quant_lit.ToString("##,##0.000") + "lt de combustivel");
            Console.Read();

        }
    }
}
