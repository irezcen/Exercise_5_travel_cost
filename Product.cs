using System;
using System.Collections.Generic;
using System.Text;

namespace zadanie_5
{
    class Product
    {
        private string name;
        private int mass;
        private int cenaZaKilogram;
        public string Name
        {
            get
            {
                return name;
            }
        }
        public int Mass
        {
            get
            {
                return mass;
            }
            set
            {
                if (value >= 0)
                {
                    mass = value;
                }
                else
                {
                    Console.WriteLine("Masa towaru nie może być mniejsza od 0");
                }
            }
        }
        public int GetCurrentValue()
        {
            cenaZaKilogram = WorldMarket.GetNewPricePerKg(cenaZaKilogram);
            return Mass * cenaZaKilogram;
        }
        public Product(string name)
        {
            this.name = name;
            this.mass = 0;
            cenaZaKilogram = WorldMarket.GetInitialPricePerKg();
        }
        public Product(string name, int mass)
        {
            this.name = name;
            this.Mass = mass;
            cenaZaKilogram = WorldMarket.GetInitialPricePerKg();
        }

    }
}
