using System;
using System.Globalization;
namespace ExericioEntradaDeDados
{
    class Program
    {
        static void Main(string[] args)
        {




            Console.WriteLine("entre com seu nome completo : ");
            string nome = Console.ReadLine();

            Console.WriteLine("Quantos quartos tem na sua casa?");
            int quartos = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o preço de um Produto :");
            double precoProd = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre seu ultimo nome, idade e altura (mesma linha) :");

            string[] v = Console.ReadLine().Split(' ');

            string sobrenome = v[0];
            int idade = int.Parse(v[1]);
            double altura = double.Parse(v[2], CultureInfo.InvariantCulture);

            Console.WriteLine(nome);
            Console.WriteLine(quartos);
            Console.WriteLine(precoProd);

            Console.WriteLine(sobrenome);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));


        }
    }
}
