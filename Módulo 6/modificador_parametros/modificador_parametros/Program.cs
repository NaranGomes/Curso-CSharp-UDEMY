using System;

namespace modificador_parametros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int s1 = Calculator.Sum(1, 2, 20, 30, 40);

            Console.WriteLine(s1);
        }
    }
}
