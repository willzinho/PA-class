using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula02
{
    class Program
    {
        static void Main(string[] args)
        {
            string a, b;
            int c;
            string nome; 
            Console.Write("Qual o seu nome: ");
            nome = Console.ReadLine();
            Console.WriteLine("Olá, " + nome);
            Console.Write("Me fale um valor qualquer: ");
            a = Console.ReadLine();
            Console.Write("Agora, " + nome + " me fale outro valor: ");
            b = Console.ReadLine();
            c = int.Parse(a) + int.Parse(b);
            Console.Write("a soma é " +  c);
            Console.ReadLine();
        }
    }
}
