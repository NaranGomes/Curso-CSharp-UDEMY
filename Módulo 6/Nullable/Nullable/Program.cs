using System;

namespace Nullable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Sintaxe possível
            Nullable<double> j = null;
            //Sintaxe mais simples
            double? x = null;
            double? y = 10.0;

            // Pega o valor da variável ou o valor padrão do tipo dela
            Console.WriteLine(x.GetValueOrDefault());
            Console.WriteLine(y.GetValueOrDefault());

            //Retrona se a variável tem ou não valor
            Console.WriteLine(x.HasValue);
            Console.WriteLine(y.HasValue);

            //Pega o valor direto da variável:
            //Dar erro se a variável tiver um valor nulo
            
            if(x.HasValue)
                Console.WriteLine(x.Value);
            else
                Console.WriteLine("X is null");

            if(y.HasValue)
                Console.WriteLine(y.Value);
            else
                Console.WriteLine("Y is null");

            //Operador de coalescência nula:
            double? a = null;
            double? b = 10;

            //Ao tentar atribuit o valor de uma variável a outra, testa se é null (??). Se sim, atribui outro valor (0.0)
            double w = a ?? 5;
            double z = b ?? 5;
            
            Console.WriteLine(w);
            Console.WriteLine(z);

            
        }
    }
}
