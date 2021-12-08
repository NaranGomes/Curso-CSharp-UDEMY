using System;
using System.Globalization;

namespace poo_ex4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario a = new Funcionario();

            Console.Write("Nome: ");
            a.Nome = Console.ReadLine();
            Console.Write("Salário Bruto: ");
            a.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            a.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("");

            Console.WriteLine("Funcioário: " + a);
            Console.WriteLine("");

            Console.WriteLine("Digite a porcentagem para aumentar o salário: ");
            double prct = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            a.AumentarSalario(prct);
            Console.WriteLine("");

            Console.WriteLine("Dados Atulaizados" + a);



        }
    }
}
