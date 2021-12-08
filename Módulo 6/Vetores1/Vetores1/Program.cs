using System;
using System.Globalization;

namespace Vetores1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double[] vect =  new double[n];

            //Armazena os valores nas posições do vetor
            for (int i = 0; i < n; i++)
            {
                vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture );
            }

            //Calcula a média das posições do vetor
            double sum = 0.0;
            for (int i = 0;i < n; i++)
            {
                sum += vect[i];
            }

            double avg = sum / n;
            Console.WriteLine("AVERAGE HEIGHT = "+ avg.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
