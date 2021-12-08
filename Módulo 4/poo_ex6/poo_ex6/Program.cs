using System;
using System.Globalization;

namespace poo_ex6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double cotacao, dolar;
            
            Console.Write("Qual é a cotação do dólar: ");
            cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantos dólares você vai comprar? ");
            dolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Valor pago em reai = " + ConversorDeMoeda.TotalEmReais(cotacao, dolar).ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
