using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Urna
{
    class Program
    {
        static void Main(string[] args)
        {
            int v, h;
            v = 1;
            while (v<=9)
            {
                Console.WriteLine(v);
            h = 0;
                while (h<=9)
                {
                    Console.Write(h);
                    h = h+1;
                }
                Console.WriteLine();
                v = v+1;
             }
            Console.ReadLine();
        }
    }
}
