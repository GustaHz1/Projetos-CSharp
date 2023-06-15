using System;

namespace Progama {
    public static class Program {
        public static void Main(string[] args) {

            int contN, cont1, cont2, i;
            int voto;
            cont2 = 0;
            cont1 = 0;
            contN = 0;

            Console.Write("Quantos Votos serão digitados? ");
            int n = int.Parse(Console.ReadLine());

            for (i = 1; i <= n; i++) {
                Console.WriteLine("Selecione o candidato que deseja votar: ");
                Console.WriteLine();
                Console.WriteLine("0 - NULO/BRANCO");
                Console.WriteLine("1 - CANDIDATO 1");
                Console.WriteLine("2 - CANDIDATO 2");
                Console.Write("Digite o numero respectivo ao candidato: ");
                voto = int.Parse(Console.ReadLine());

                Console.WriteLine();

                if (voto == 0) {
                    Console.WriteLine("VOTO EM BRANCO");
                    contN = contN + 1;
                }
                if (voto == 1) {
                    Console.WriteLine("VOTO PARA O CANDIDATO 1 ");
                    cont1 = cont1 + 1;
                }
                if (voto == 2) {
                    Console.WriteLine("VOTO PARA O CANDIDATO 2 ");
                    cont2 = cont2 + 1;
                }
                if (voto > 2) {
                    Console.WriteLine("VOTO INVALIDO");
                    Console.Write("VOTE NOVAMENTE: ");
                    voto = int.Parse(Console.ReadLine());
                    if (voto == 0) {
                        Console.WriteLine("VOTO EM BRANCO");
                        contN = contN + 1;
                    }
                    if (voto == 1) {
                        Console.WriteLine("VOTO PARA O CANDIDATO 1 ");
                        cont1 = cont1 + 1;
                    }
                    if (voto == 2) {
                        Console.WriteLine("VOTO PARA O CANDIDATO 2 ");
                        cont2 = cont2 + 1;
                    }
                    }
            }

            Console.WriteLine();
            Console.WriteLine("Contagem de votos: ");
            Console.WriteLine("Votos em branco/nulo : " + contN);
            Console.WriteLine("Votos no candidato 1: " + cont1);
            Console.WriteLine("Votos no candidato 2: " + cont2);
            Console.WriteLine();

            if (cont1 > cont2) {
                Console.WriteLine("VENCEDOR CANDIDATO 1");
            }
            else {
                if (cont2 > cont1) {
                Console.WriteLine("VENCEDOR CANDIDATO 2");
                }
            }
            if (cont1 == cont2) {
                Console.WriteLine("EMPATE");
            }
        }
    }
}


