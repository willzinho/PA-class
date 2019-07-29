using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace menu
{
    class Program
    {
        static void Main(string[] args)
        {
         int opcao, voto, cand, cand33, cand44, cand55, cand77, cand88, totalvotos;
         string resp;
         opcao = 0;
         voto = 0;
         cand = 0;
         cand33 = 0;
         cand44 = 0;
         cand55 = 0;
         cand77 = 0;
         cand88 = 0;
            while (opcao <= 0 || opcao >= 4)
            {
                Console.WriteLine("***URNA ELETRONICA***");
                Console.WriteLine();
                Console.WriteLine("1 - VOTAR");
                Console.WriteLine("2 - RELATÓRIO");
                Console.WriteLine("3 - FIM");
                Console.WriteLine("Qual a sua opção? ");
                opcao = int.Parse(Console.ReadLine());
                if (opcao <= 0 || opcao >= 4)
                {
                    Console.Write("Opção invalida! Tente novamente. <ENTER> para continuar.");
                    Console.ReadLine();
                    Console.Clear();
                }
                if (opcao == 3)
                    break;
                else if (opcao == 1)
                {
                    resp = "n";
                    while (resp != "s")
                    {
                        Console.Clear();
                        Console.WriteLine("33 - Macaco Tião");
                        Console.WriteLine("44 - Urso Panda");
                        Console.WriteLine("55 - Mico Leão");
                        Console.WriteLine("77 - Branco");
                        Console.WriteLine("88 - Nulo");
                        Console.Write("Qual o seu candidato? ");
                        cand = int.Parse(Console.ReadLine());
 
                        if (cand == 33)
                            Console.WriteLine("Seu voto é: " + cand + " Macaco Tião!");

                        if (cand == 44)
                            Console.WriteLine("Seu voto é: " + cand + " Urso Panda!");

                        if (cand == 55)
                           Console.WriteLine("Seu voto é: " + cand + " Mico Leão!");
   
                        if (cand == 77)
                            Console.WriteLine("Seu voto é: " + cand + " Branco!");
                               
                        if (cand == 88)
                            Console.WriteLine("Seu voto é: " + cand + " Nulo!");
                           
                        
                        //confirmação do voto
                    Console.WriteLine("Você comfirma o seu voto (S/N) ");
                    resp = Console.ReadLine();
                   
                      Console.Clear();
                        opcao = 0;
                        if (resp == "s")
                        {
                            if (cand == 33)
                                cand33++;

                            else if (cand == 44)
                                cand44++;

                            else if (cand == 55)
                                cand55++;

                            else if (cand == 77)
                                cand77++;

                            else 
                                cand88++;
                        }
                    }
                }
                else if (opcao == 2)
                {
                    //menu relatório
                    Console.WriteLine("33 - Macaco Tião........ " + cand33);
                    Console.WriteLine("44 - Urso Panda......... " + cand44);
                    Console.WriteLine("55 - Mico Leão.......... " + cand55);
                    Console.WriteLine("77 - Branco............. " + cand77);
                    Console.WriteLine("88 - Nulo............... " + cand88);
                    totalvotos = cand33 + cand44 + cand55 + cand77 + cand88;
                    Console.WriteLine("RELATÓRIO TOTAL DE VOTOS ....... " + totalvotos);
                    Console.ReadLine();
                    Console.Clear();
                }
            }   


        }
    }
}
