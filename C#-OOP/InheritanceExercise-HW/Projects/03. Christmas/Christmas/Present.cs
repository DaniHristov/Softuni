﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Christmas
{
    class Present
    {
        public Present(string name , double weight , string gender)
        {
            Name = name;
            Weight = weight;
            Gender = gender;
        }
        public string Name { get; set; }

        public double Weight { get; set; }

        public string Gender { get; set; }

        public override string ToString()
        {
            return $"Present {Name} ({Weight}) for a {Gender}";
        }
    }
}
