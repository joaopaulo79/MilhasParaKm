using System;

namespace MilhasParaKm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("==== Conversor de Milhas para Km ====");
            Console.WriteLine();
            Console.Write("Digite a medida em milhas: ");
            Console.ResetColor();
            string milhaDIG = Console.ReadLine();
            double milhas = Convert.ToDouble(milhaDIG);
            double km = milhas * 1.609;
            Console.WriteLine();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("== Conversão ==");
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine($"{milhas} milhas são {km:N3}km");
            Console.WriteLine();
        }
    }
}
