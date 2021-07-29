using System;
using System.Globalization;
namespace ExercicioFixação
{
    class Program
    {
        static void Main(string[] args)
        {
            string produto1 = "Computador";
            string produto2 = "Mesa de escritorio";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double media = 53.234567;



            Console.WriteLine("Produtos:");
            Console.WriteLine($"{produto1}, cujo preco e ${preco1:F2} ");
            Console.WriteLine($"{produto2}, cujo preco e {preco2:F2}");
            Console.WriteLine($"Registro: {idade} anos de idade, codigo {codigo} e genero {genero}:");

            Console.WriteLine($" Media com oito casas decimais: {media:F8}");
            Console.WriteLine($"Arredondamento (Tres casas decimais): {media:F3}");
            Console.WriteLine("Separador decimal invariant culture:" + media.ToString("F3",CultureInfo.InvariantCulture));
        }
    }
}
