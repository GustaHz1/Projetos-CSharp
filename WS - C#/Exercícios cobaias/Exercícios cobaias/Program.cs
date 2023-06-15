using System;

namespace Progama {
    public static class Program {
        public static void Main(string[] args) {

            int i, n, qntCobaias, totalCobaias, totalCoelhos, totalSapos, totalRatos;
            char C, R, S, tipoCobaia;
            double pCoelhos, pSapos, pRatos;

            totalCobaias = 0;
            totalCoelhos = 0;
            totalSapos = 0;
            totalRatos = 0;

            Console.Write("Quantos casos de teste serao digitados: ");
            n = int.Parse(Console.ReadLine());

            for (i = 1; i <= n; i++) {
                Console.Write("Quantidade de cobaias: ");
                qntCobaias = int.Parse(Console.ReadLine());
                Console.Write("Tipo da cobaia: ");
                tipoCobaia = char.Parse(Console.ReadLine());

                if (tipoCobaia == 'C') {
                    totalCoelhos = (totalCoelhos + qntCobaias);
                    totalCobaias = (totalCobaias + qntCobaias);
                }
                else
                    if (tipoCobaia == 'S') {
                    totalSapos = (totalSapos + qntCobaias);
                    totalCobaias = (totalCobaias + qntCobaias);
                }else 
                if (tipoCobaia == 'R') {
                    totalRatos = ( totalRatos + qntCobaias);
                    totalCobaias = (totalCobaias + qntCobaias);
                  
                }

                

            }

            pCoelhos = ((double)totalCoelhos / totalCobaias ) * 100;
            pRatos = ((double)totalRatos / totalCobaias) * 100;
            pSapos = ((double)totalSapos / totalCobaias) * 100;



            Console.WriteLine();
            Console.WriteLine("RELATORIO FINAL: ");
            Console.WriteLine("Total Cobaias: " + totalCobaias);
            Console.WriteLine("Total Coelhos: " + totalCoelhos);
            Console.WriteLine("Total sapos: " + totalSapos);
            Console.WriteLine("Total ratos: " + totalRatos);
            Console.WriteLine("Percentual de Coelhos: " + pCoelhos.ToString("F2"));
            Console.WriteLine("Percentual de Sapos: " + pSapos.ToString("F2"));
            Console.WriteLine("Percentual de Ratos: " + pRatos.ToString("F2"));

        }
    }
}

