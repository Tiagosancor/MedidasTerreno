using System;
using System.Globalization;

namespace MedidasTerreno
{
    class Program
    {
        static void Main(string[] args)
        {
            Terreno terreno = new Terreno();

            Console.WriteLine("Informe a Largura do terreno:");
            terreno.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Informe o comprimento do terreno:");
            terreno.Comprimento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Informe o preço por metro quadrado:");
            terreno.PrecoMtq = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine(terreno);
            
        }
    }
}
