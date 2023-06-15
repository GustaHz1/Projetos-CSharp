using System;
using System.Security.Principal;

namespace Progama {
    public static class Program {
        public static void Main(string[] args) {

            int n, contC, contE;
            contC = 0;
            contE = 0;

            Console.Write("Quantas vezes ira digitar o numero? ");
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++) {
                Random random = new Random();
                int R = random.Next(1, 10);
                Console.Write("Digite um numero de 1 a 10: ");
                int A = int.Parse(Console.ReadLine());

                while (A > 10 || A == 0) {
                    Console.Write("Numero Invalido digite novamente: ");
                    A = int.Parse(Console.ReadLine());
                }
                    if (A == R) {
                        Console.WriteLine("Numero correto " + " Valor de R = " + R);
                        contC = contC + 1;
                    }
                    else if (A != R) {
                        Console.WriteLine("Numero errado " + " Valor de R = " + R);
                        contE = contE + 1;
                    }
            }
            Console.WriteLine();
            Console.WriteLine("Numero de acertos: " + contC);
            Console.WriteLine("Numero de erros: " + contE);
        }
    }
   }


