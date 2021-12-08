using System;
using System.Globalization;

namespace poo_ex3
{
    internal class Retangulo
    {
        public double Altura;
        public double Largura; 

        public double Area()
        {
           return Largura * Altura;           
        }
        public double Perimetro()
        {
            return (Largura * 2) + (Altura * 2);
        }
        public double Diagonal()
        {
            return Math.Sqrt(Math.Pow(Altura, 2) + Math.Pow(Largura, 2));
        }
    }
}
