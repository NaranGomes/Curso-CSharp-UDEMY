using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeKind
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = new DateTime(2000, 08, 15, 23, 50, 15, System.DateTimeKind.Local);

            Console.WriteLine(d1);
            Console.WriteLine(d1.ToUniversalTime());
        }
    }
}
