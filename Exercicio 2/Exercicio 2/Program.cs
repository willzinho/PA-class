using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Faça um algoritimo que leia as 3 notas de um aluno e calcule a media final deste aluno. Considerar qua media é a SOMA DAS NOTAS dividido por 3.
            float nt1, nt2, nt3, Media;
            Console.Write("Primeira nota: ");
            nt1 = float.Parse(Console.ReadLine());
            Console.Write("Segunda nota: ");
            nt2 = float.Parse(Console.ReadLine());
            Console.Write("Terceira nota: ");
            nt3 = float.Parse(Console.ReadLine());
            Media = (nt1 + nt2 + nt3) / 3;
            Console.Write("A media do aulo é : " + Media);
            Console.ReadLine();

        }
    }
}
