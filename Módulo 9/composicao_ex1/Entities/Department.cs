﻿using System;

namespace composicao_ex1.Entities
{
    internal class Department
    {
        public string Name { get; set; }

        public Department()
        {
        }

        public Department(string name)
        {
            Name = name;
        }
    }
}
