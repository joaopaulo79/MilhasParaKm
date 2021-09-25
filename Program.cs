using System;

namespace MilhasParaKm
{
    class Program
    {
        static void Main(string[] args)
        {
            double milhas, km;
        
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\n==== Conversor de Milhas para Km ====\n");
            Console.ResetColor();

            Console.WriteLine("Digite a medida em milhas, para\nconverter em km.\n");
            
            
            Console.Write("Medida em milhas: ");
            milhas = Convert.ToDouble(Console.ReadLine());

            km = milhas * 1.609;

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\n== Conversão ==\n");
            Console.ResetColor();
 
            Console.WriteLine($"{milhas} milhas são {km:N3}km\n");
        }
    }
}
