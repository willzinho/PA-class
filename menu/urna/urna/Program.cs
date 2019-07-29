using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace urna
{
    class Program
    {
        static void Main(string[] args)
        {
            string resp;
            int opcao;
            int cand33 = 0, cand44 = 0, cand55 = 0, cand77 = 0, cand88 = 0;
            int voto=0;

            opcao = 0;
            while (opcao <= 0 || opcao >= 4) // || operador OU
            {
                Console.WriteLine("*** URNA ELETRÔNICA ***");
                Console.WriteLine();
                Console.WriteLine("1 - VOTAR");
                Console.WriteLine("2 - RELATÓRIO");
                Console.WriteLine("3 - FIM");
                Console.WriteLine();
                Console.Write("Qual sua opção: ");
                opcao = int.Parse(Console.ReadLine());
                if (opcao <= 0 || opcao >= 4)
                {
                    Console.Write("Opção invalida! Tente novamente. <ENTER> para continuar");
                    Console.ReadLine(); // faz pausa
                    Console.Clear(); // limpa tela
                }
                if (opcao == 3)
                    break; // finaliza o programa
                else if (opcao == 1)
                {
                    resp = "n";
                    while (resp != "s")
                    {
                        // Menu de candidatos                        
                        Console.Clear();
                        Console.WriteLine("*** URNA ELETRONICA ***");
                        Console.WriteLine();
                        Console.WriteLine("33 - MACACO TIAO");
                        Console.WriteLine("44 - URSO PANDA");
                        Console.WriteLine("55 - MICO LEAO");
                        Console.WriteLine("77 - BRANCO");
                        Console.WriteLine("88 - NULO");
                        Console.WriteLine();
                        Console.Write("Digite seu voto: ");
                        voto = int.Parse(Console.ReadLine());
                        Console.WriteLine("==================================");
                        if (voto == 33)
                            Console.WriteLine("SEU VOTO É: MACACO TIAO");
                        else if (voto == 44)
                            Console.WriteLine("SEU VOTO É: URSO PANDA");
                        else if (voto == 55)
                            Console.WriteLine("SEU VOTO É: MICO LEAO");
                        else if (voto == 77)
                            Console.WriteLine("SEU VOTO É: BRANCO");
                        else
                            Console.WriteLine("SEU VOTO É: NULO");

                        Console.WriteLine("===================================");
                        Console.Write("Confirme seu voto (S/N)");
                        resp = Console.ReadLine();
                    }
                    Console.Clear();
                    opcao = 0;
                    if (resp == "s")
                    {
                        if (voto == 33)
                            cand33++;
                        else if (voto == 44)
                            cand44++;
                        else if (voto == 55)
                            cand55++;
                        else if (voto == 77)
                            cand77++;
                        else
                            cand88++;
                    }

                }
                else if (opcao == 2)
                {
                    // menu relatorio
                    Console.Clear();
                    Console.WriteLine("================================");
                    Console.WriteLine("*** ELEIÇOES APURAÇAO ***");
                    Console.WriteLine("================================");
                    Console.WriteLine("MACACO TIAO............." + cand33);
                    Console.WriteLine("URSO PANDA.............." + cand44);
                    Console.WriteLine("MICO LEAO..............." + cand55);
                    Console.WriteLine("BRANCO.................." + cand77);
                    Console.WriteLine("NULO...................." + cand88);
                    Console.WriteLine("================================");
                    int todosvotos = 0;
                    todosvotos = cand33 + cand44 + cand55 + cand77 + cand88;
                    Console.WriteLine("TOTAL DE VOTOS.........." + todosvotos);
                    Console.ReadLine();

                }

            }
        }
    }
}
