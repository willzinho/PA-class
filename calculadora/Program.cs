using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao, valor1, valor2, resultado;
            opcao = 0;
            valor1 = 0;
            valor2 = 0;

            while (opcao <= 0 || opcao >= 6)
            {
                Console.WriteLine("***CALCULADORA***");
                Console.WriteLine();
                Console.WriteLine("1 - ADIÇÃO");
                Console.WriteLine("2 - SUBTRAÇÃO");
                Console.WriteLine("3 - MULTIPLICAÇÃO");
                Console.WriteLine("4 - DIVISÃO");
                Console.WriteLine("5 - SAIR");
                Console.WriteLine("Qual a sua opção? ");
                opcao = int.Parse(Console.ReadLine());
                if (opcao <= 0 || opcao >= 6)
                {
                    Console.Write("Opção invalida! Tente novamente. <ENTER> para continuar.");
                    Console.ReadLine();
                    Console.Clear();
                }
                if (opcao == 5)
                    break;

                if (opcao == 1)
                {
                    Console.Clear();
                    Console.WriteLine(" A OPERAÇÃO ESCOLHIDA É: ADIÇÃO!");
                    Console.Write("INFORME O VALOR 1: ");
                    valor1 = int.Parse(Console.ReadLine());
                    Console.Write("INFORME O VALOR 2: ");
                    valor2 = int.Parse(Console.ReadLine());
                    resultado = valor1 + valor2;
                    Console.WriteLine("O RESULTADO É: " + resultado);
                    Console.ReadLine();
                    Console.Clear();
                    opcao = 0;
                }
                else if (opcao == 2)
                {
                    Console.Clear();
                    Console.WriteLine(" A OPERAÇÃO ESCOLHIDA É: SUBTRAÇÃO!");
                    Console.WriteLine("INFORME O VALOR 1: ");
                    valor1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("INFORME O VALOR 2: ");
                    valor2 = int.Parse(Console.ReadLine());
                    resultado = valor1 - valor2;
                    Console.WriteLine("O RESULTADO É: " + resultado);
                    Console.ReadLine();
                    Console.Clear();
                    opcao = 0;
                }
                else if (opcao == 3)
                {
                    Console.Clear();
                    Console.WriteLine(" A OPERAÇÃO ESCOLHIDA É: MULTIPLICAÇÃO!");
                    Console.WriteLine("INFORME O VALOR 1: ");
                    valor1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("INFORME O VALOR 2: ");
                    valor2 = int.Parse(Console.ReadLine());
                    resultado = valor1 * valor2;
                    Console.WriteLine("O RESULTADO É: " + resultado);
                    Console.ReadLine();
                    Console.Clear();
                    opcao = 0;
                }
                else if (opcao == 4)
                {
                    Console.Clear();
                    Console.WriteLine(" A OPERAÇÃO ESCOLHIDA É: DIVISÃO!");
                    Console.WriteLine("INFORME O VALOR 1: ");
                    valor1 = int.Parse(Console.ReadLine());
                    valor2 = 0;
                    while (valor2 <= 0)
                    {
                        Console.WriteLine("INFORME O VALOR 2: ");
                        valor2 = int.Parse(Console.ReadLine());
                        if (valor2 == 0)
                        {
                            Console.Write("Opção invalida! 0 não pode dividir! Tente novamente. <ENTER> para continuar.");
                            Console.ReadLine();
                            Console.Clear();
                        }
                        else
                        {
                            resultado = valor1 / valor2;
                            Console.WriteLine("O RESULTADO É: " + resultado);
                            Console.ReadLine();
                            Console.Clear();
                            opcao = 0;
                        }
                    }
                }
            }
        }
    }
}
