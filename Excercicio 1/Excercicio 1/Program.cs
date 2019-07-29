using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, soma;
            Console.Write("Entre com um numero: ");
            n1 = int.Parse(Console.ReadLine());
            Console.Write("Entre com outro numero: ");
            n2 = int.Parse(Console.ReadLine());
            soma = n1 + n2;
            Console.WriteLine("A soma é : " + soma);
            Console.WriteLine("Pressione ENTER para sair.");
            Console.ReadLine();

        }
    }
}
