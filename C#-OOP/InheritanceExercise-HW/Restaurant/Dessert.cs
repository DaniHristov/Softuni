﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    class Dessert : Food
    {
        public Dessert(string name, decimal price, double grams , double calories) : base(name, price, grams)
        {
            this.Calories = calories;
        }

        public virtual double Calories { get; set; }    
    }
}
