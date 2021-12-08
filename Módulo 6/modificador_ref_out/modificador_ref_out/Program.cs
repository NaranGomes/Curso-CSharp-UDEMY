using System;

namespace modificador_ref_out
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;
            int dobro;

            Calculator.Triple(ref a);
            Console.WriteLine(a);

            Calculator.Double(b, out dobro);
            Console.WriteLine(dobro);


        }
    }
}
