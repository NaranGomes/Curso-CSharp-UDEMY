using System;

namespace modulo6_ex1
{
    internal class Quarto
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public int Room { get; set; }

        public override string ToString()
        {
            return Room
                + ": "
                + Name
                + ", "
                + Email;
        }
    }
}
