using System;
using System.Globalization;
namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            double largura, comprimento, precoMetroQuadrado, area, preco;
            Console.WriteLine("Entre com o valor da largura do terreno:");
            largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com o comprimento do terreno:");
            comprimento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com o preço do terreno:");
            precoMetroQuadrado = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = largura * comprimento;
            preco = area * precoMetroQuadrado;


            Console.WriteLine("Area do terreno= " + area.ToString("F2", CultureInfo.InvariantCulture));
            
            Console.WriteLine("Preço do terreno= " + preco.ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadLine();




            
        }
    }
}