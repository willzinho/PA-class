using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exercicio 3 - lista 2
            int v1, v2;
            Console.Write("Informe o valor : ");
            v1 = int.Parse(Console.ReadLine());
            Console.Write("Informe outro valor : ");
            v2 = int.Parse(Console.ReadLine());
            if (v1 == v2)
                Console.WriteLine("Os numeros são iguais");
            else
            if (v1 > v2)
                Console.WriteLine("Primeiro numero é maior");
            else
                Console.WriteLine("Segundo numero é maior");
            Console.Read();
        }
    }
}
