using System;

namespace Progama {
    public static class Program {
        public static void Main(string[] args) {

            int voto, contN, cont2, cont1;
            contN = 0;
            cont2 = 0;
            cont1 = 0;

            Console.Write("Digite quantos votos serão contabilizados? ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("0 - NULO/BRANCO");
            Console.WriteLine("1 - CANDIDATO 1");
            Console.WriteLine("2 - CANDIDATO 2");

            for (int i = 0; i < n; i++) {
                Console.Write("Digite o número respectivo ao candidato: ");
                voto = int.Parse(Console.ReadLine());
                switch (voto) {

                    case 0:
                         Console.WriteLine("VOTO NULO");
                         contN = contN + 1;
                        break;
                    case 1:
                        Console.WriteLine("VOTO PARA O CANDIDATO 1");
                        cont1 = cont1 + 1;
                        break;
                    case 2:
                        Console.WriteLine("VOTO PARA O CANDIDATO 2");
                        cont2 = cont2 + 1;  
                        break;
                    default:
                        Console.WriteLine("VOTO INVALIDO");
                        Console.Write("Digite novamente: ");
                        voto = int.Parse(Console.ReadLine());
                        if (voto == 0) {
                            Console.WriteLine("VOTO NULO");
                            contN = contN + 1;
                        }
                        else if (voto == 1) {
                            Console.WriteLine("VOTO PARA O CANDIDATO 1");
                            cont1 = cont1 + 1;
                        }
                        else if (voto == 2) {
                            Console.WriteLine("VOTO PARA O CANDIDATO 2");
                            cont2 = cont2 + 1;
                        }
                        break;
                }   
        }
            Console.WriteLine();
            Console.WriteLine("Resultado: ");
            Console.WriteLine("Votos em branco: " + contN);
            Console.WriteLine("Votos no candidato 1: " + cont1);
            Console.WriteLine("Votos no candidato 2: " + cont2);

            Console.WriteLine();
            Console.Write("VENCEDOR: ");

            if (cont1 > cont2) {
                Console.WriteLine("VENCEDOR CANDIDATO 1");
            }else if (cont2 > cont1) {
                Console.WriteLine("VENCEDOR CANDIDATO 2");
            }else {
                Console.WriteLine("EMPATE");
            }
    }
}
}

