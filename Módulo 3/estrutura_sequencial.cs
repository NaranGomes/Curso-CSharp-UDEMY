using System;
using System.Globalization;

namespace exercicios1_estrutura_sequencial
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercício 1 - Faça um programa para ler dois valores inteiros, e depois mostrar na tela a soma desses números com uma
			//mensagem explicativa, conforme exemplos.

            Console.WriteLine("Insira o primeiro valor inteiro: ");
            int v1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o segundo valor inteiro: ");
            int v2 = int.Parse(Console.ReadLine());
            int valorFinal = v1 + v2;

            Console.WriteLine("SOMA = " + valorFinal);

            //Exercício 2 - Faça um programa para ler o valor do raio de um círculo, e depois mostrar o valor da área deste círculo com quatro
			//casas decimais conforme exemplos.
			//Fórmula da área: area = π . raio2
			//Considere o valor de π = 3.14159

            Console.WriteLine("Digite o valor do raio:");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double area = 3.14159 * Math.Pow(raio, 2);

            Console.WriteLine("A=" + area.ToString("F4", CultureInfo.InvariantCulture));

            //Exercício 3 - Fazer um programa para ler quatro valores inteiros A, B, C e D. A seguir, calcule e mostre a diferença do produto
			//de A e B pelo produto de C e D segundo a fórmula: DIFERENCA = (A * B - C * D).

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());

            int dif = (a * b) - (c * d);
            Console.WriteLine("DIFERENÇA =" + dif);

            //Exercício 4 - Fazer um programa que leia o número de um funcionário, seu número de horas trabalhadas, o valor que recebe por
			//hora e calcula o salário desse funcionário. A seguir, mostre o número e o salário do funcionário, com duas casas
			//decimais.

            int number = int.Parse(Console.ReadLine());
            double horas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double valorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double salario = horas * valorHora;
            Console.WriteLine("NUMBER = " + number);
            Console.WriteLine("SALARY = U$ " + salario.ToString("F2", CultureInfo.InvariantCulture));

            //Exercício 6 - Fazer um programa que leia três valores com ponto flutuante de dupla precisão: A, B e C. Em seguida, calcule e
			//mostre:
			//a) a área do triângulo retângulo que tem A por base e C por altura.
			//b) a área do círculo de raio C. (pi = 3.14159)
			
            double a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double a_ex = (a * c) / 2;
            double b_ex = Math.Pow(c, 2) * 3.14159;

            Console.WriteLine("TRIANGULO: " + a_ex.ToString("F3",CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: " + b_ex.ToString("F3", CultureInfo.InvariantCulture));

        }
    }
}
