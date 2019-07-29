using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int v1;
            Console.Write("Informe um valor : ");
            v1 = int.Parse(Console.ReadLine());
            if (v1 >= 1)
            Console.WriteLine("valor é positivo.");
            else
            if (v1 < 0)
                Console.Write("valor é negativo.");
            else
            if (v1 == 0)
            Console.WriteLine("Valor igual a zero.");
            Console.ReadLine();

        }
    }
}
