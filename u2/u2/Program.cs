using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace u2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            x = 0;
            while (x <= 0 || x >= 6)
            {
                Console.Write("Digite um número de 1 a 5: ");
                x = int.Parse(Console.ReadLine());
                if (x <= 0 || x >= 6)
                {
                    Console.Write("Valor invalido! <Enter> para continuar");
                    Console.ReadLine();
                    Console.Clear();
                }
            }

        }
    }
}
