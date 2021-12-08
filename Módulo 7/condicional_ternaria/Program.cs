using System;
using System.Globalization;

namespace condicional_ternaria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double preco = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double desconto = (preco < 20) ? preco * 0.1 : preco * 0.05;

            /*if (desconto < 20)
            {
                desconto = preco * 0.1;
            }else
            {
                desconto = preco * 0.05;
            }*/

            Console.WriteLine(desconto);
        }
    }
}
