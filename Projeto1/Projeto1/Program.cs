using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto1
{
    class Program
    {
        static void Main(string[] args)
        {
            float n1, n2, n3, n4;
            float media, freq;
            Console.WriteLine("Calculo da Media");
            Console.WriteLine();
            Console.WriteLine("Qual a primeira nota: ");
            n1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Qual a segunda nota: ");
            n2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Qual a terceira nota: ");
            n3 = float.Parse(Console.ReadLine());
            Console.WriteLine("Qual a quarta nota: ");
            n4 = float.Parse(Console.ReadLine());
            Console.WriteLine("Frequencia do Aluno? ");
            freq = float.Parse(Console.ReadLine());
            media = (n1 + n2 + n3 + n4) / 4;
            Console.WriteLine();
            Console.WriteLine("Media Final = " + media.ToString("00.00"));
            if (media >= 7 && freq >= 75) 
                Console.WriteLine("Aluno Aprovado! ");
            else
                Console.WriteLine("Aluno Reprovado!");
            Console.ReadLine();
        }
    }
}
