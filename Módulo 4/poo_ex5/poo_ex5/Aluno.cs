using System;
using System.Globalization;

namespace poo_ex5
{
    internal class Aluno
    {
        public double PrimeiroTrimestre;
        public double SegundoTrimestre;
        public double TerceiroTrimestre;

        public double NotaFinal()
        {
            return PrimeiroTrimestre + SegundoTrimestre + TerceiroTrimestre;
        }
        public double NotaNecessaria()
        {
            return 60.00 - NotaFinal();
        }
    }
}
