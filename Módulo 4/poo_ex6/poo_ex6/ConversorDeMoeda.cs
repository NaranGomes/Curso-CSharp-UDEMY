using System;
using System.Globalization;

namespace poo_ex6
{
    internal class ConversorDeMoeda
    {

        static public double TotalEmReais(double cotacao, double dolar)
        {
            double total = cotacao * dolar;
            total = total + (total * 6.0 / 100);
            return total;
        }
    }
}
