﻿using Easter.Models.Eggs.Contracts;
using Easter.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Text;

namespace Easter.Models.Eggs
{
    public class Egg : IEgg
    {
        private string name;
        private int energyRequired;
        public Egg(string name, int energyRequired)
        {
            this.Name = name;
            this.EnergyRequired = energyRequired;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.InvalidEggName);
                }
                this.name = value;
            }
        }

        public int EnergyRequired
        {
            get
            {
                return this.energyRequired;
            }
            private set
            {
                if (value<0)
                {
                    value = 0;
                }
                this.energyRequired = value;
            }
        }

        public void GetColored()
        {
            energyRequired -= 10;
            if (energyRequired < 0)
            {
                energyRequired = 0;
            }
        }

        public bool IsDone()
        {
            if (energyRequired == 0)
            {
                return true;
            }
            return false;
        }
    }
}
