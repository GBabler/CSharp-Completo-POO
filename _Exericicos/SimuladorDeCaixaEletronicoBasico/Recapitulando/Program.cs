using System;

namespace Recapitulando
{
    class Program
    {
        static void Main(string[] args)
        {
            double saldo = 0.00;
            double depositar = 0.00;
            double sacar = 0.00;

            bool a = true;
            while (a)
            {

                

                Console.WriteLine("1 - SALDO");
                Console.WriteLine("2 - SACAR");
                Console.WriteLine("3 - DEPOSITAR");
                int valor = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (valor)
                {
                    case 1:

                        Console.WriteLine("seu saldo no banco é de R$ " + saldo.ToString("F2"));
                        Console.WriteLine("==============================");
                       
                        break;

                    case 2:

                        Console.Write("Informe o valor que deseja sacar R$ ");
                        sacar = double.Parse(Console.ReadLine());
                        Console.Clear();

                        saldo = saldo - sacar;

                        Console.WriteLine("Voce sacou R$ " + sacar.ToString("F2"));
                        Console.WriteLine("Seu saldo atual e de R$ " + saldo.ToString("F2"));
                        Console.WriteLine("==============================");

                        break;

                    case 3:
                        Console.Write("Insira o valor que deseja depositar R$" );
                        depositar = double.Parse(Console.ReadLine());
                        Console.Clear();
                        Console.WriteLine("Voce depositou R$ " + depositar);
                        saldo = saldo + depositar;
                        Console.WriteLine("Seu saldo atual e de R$ " + saldo.ToString("F2"));
                        Console.WriteLine("==============================");

                        
                        break;
                    
                }
                
            }
        }
        
    }
}
