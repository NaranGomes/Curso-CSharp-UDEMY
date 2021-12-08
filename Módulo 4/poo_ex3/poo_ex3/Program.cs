using System;
using System.Globalization;

namespace poo_ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Retangulo r = new Retangulo();
            double area, perimetro, diagonal;

            Console.WriteLine("Entre a largura e altura do retângulo: ");
            r.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            r.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = r.Area();
            perimetro = r.Perimetro();
            diagonal = r.Diagonal();

            Console.WriteLine("ÁREA = " + area.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("PERÍMETRO = " + perimetro.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("DIAGONAL = " + diagonal.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
