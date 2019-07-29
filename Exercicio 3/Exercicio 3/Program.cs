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
            //Escreva um algoritmo que armazene o valor 10 em uma variavel A e o valor 20 em uma variavel B. A seguir (utilizando apenas atribuiçoes entre variaveis) troque os seus conteudos fazendo com que esta em A passe par B e vice-versa. Ao final, escrever os valores que ficaram armazenados nas variaveis.
            int a, b, c;
            a = 10;
            b = 20;
            c = a;
            a = b;
            b = c;
            Console.Write(a + " ");
            Console.Write(b);
            Console.ReadLine();
        }
    }
}
