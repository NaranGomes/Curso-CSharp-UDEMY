using System;

namespace modulo6_ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Quarto[] vect = new Quarto[10];

            Console.Write("How many rooms will be entered? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Rent #" + i +":");
                Console.WriteLine("Name: ");
                string name = Console.ReadLine();
                Console.WriteLine("Email: ");
                string email = Console.ReadLine();
                Console.WriteLine("Room: ");
                int room = int.Parse(Console.ReadLine());
                
                vect[room] = new Quarto { Email = email, Name = name, Room = room };
            }
            
            for (int i = 0; i < 10; i++)
            {
                if (vect[i] != null)
               Console.WriteLine(vect[i]);
            }
        }
    }
}
