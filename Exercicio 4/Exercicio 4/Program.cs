using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Escreva um algoritmo para ler um valo e escrever seu antecessor.
            int n1, resultado;
            Console.Write("Digite um valor: ");
            n1 = int.Parse(Console.ReadLine());
            resultado = n1 - 1;
            Console.Write("Resultado é: " + resultado);
            Console.ReadLine();
        }
    }
}
