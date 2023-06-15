using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            int Saldo, Escolha;
            Saldo = 0;
            bool i = false;

            Console.WriteLine(" -----BEM VINDO AO APLICATIVO DO BANCO----- ");
            Console.Write("Cadastre um Email: ");
            string Email = Console.ReadLine();
            Console.Write("Cadastre uma Senha: ");
            int Senha = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite seu email e senha para entrar ");
            string email = Console.ReadLine();
            int senha = int.Parse(Console.ReadLine());

            while (email != Email || senha != Senha)
            {
                Console.Write("Email ou Senha invalidos digite novamente: ");
                email = Console.ReadLine();
                senha = int.Parse(Console.ReadLine());
            }

            Console.Write("Cadestre seu nome: ");
            string Name = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("Parabens voce terminou de se cadastrar em nosso aplicativo!!! ");
            Console.WriteLine();
            Console.WriteLine("----------------------------------------------------------------------------");
            Console.WriteLine();

            Console.WriteLine("-----Usuario: " + Name + "----- ");
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("|-----------------------------------|");
            Console.WriteLine("|1-Verificar Saldo:                 |");
            Console.WriteLine("|2-Depositar dinheiro:              |");
            Console.WriteLine("|3-Retirar dinheiro:                |");
            Console.WriteLine("|4-Sair                             |");
            Console.WriteLine("|-----------------------------------|");

            do
            {
                Console.Write("Qual operação deseja fazer? ");
                Escolha = int.Parse(Console.ReadLine());
                switch (Escolha)
                {
                    case 1:
                        Console.WriteLine("Seu saldo é: " + Saldo);
                        break;
                    case 2:
                        Console.Write("Quanto deseja depositar? ");
                        int NewSaldo = int.Parse(Console.ReadLine());
                        Saldo = Saldo + NewSaldo;
                        break;
                    case 3:
                        Console.WriteLine("Quanto deseja retirar? ");
                        int RetSaldo = int.Parse(Console.ReadLine());
                        Saldo = Saldo - RetSaldo;
                        break;
                    case 4:
                        i = true;
                        Console.WriteLine("Fim do progama");
                        
                        break;
                }
            } while (i = true );
        }
    }
}


