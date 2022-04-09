using B5;
using System;
using System.Collections.Generic;
using System.Text;

namespace zadanie_5
{
    class Ship
    {
        private int mass;
        public Engine Engine
        {
            get;
            set;
        }
        public bool TravelOffer(Destination destination, Product product1, Product product2)
        {
            int sellProduct = product1.GetCurrentValue() + product2.GetCurrentValue();
            int travelCost = Engine.TravelCost(destination.Distance, (mass + product1.Mass + product2.Mass));
            if((sellProduct - travelCost) >= 1000)
            {
                Console.WriteLine("Accepted");
                Console.WriteLine("Ship cargo: ");
                Console.WriteLine(product1.Name + " " + product1.Mass + "t");
                Console.WriteLine(product2.Name + " " + product2.Mass + "t");
                Console.WriteLine("Travel time: " + Engine.TravelTime(destination.Distance, (mass + product1.Mass + product2.Mass)) + "h");
                Console.WriteLine("Products value: " + sellProduct);
                Console.WriteLine("Travel cost: " + travelCost);
                return true;
            }
            else
            {
                Console.WriteLine("Denied");
                return false;
            }
        }
        public Ship()
        {
            Engine = new Engine("diesel");
            mass = 40000;
        }
        public Ship(Engine engine, int mass)
        {
            this.Engine = engine;
            if (mass > 0)
            {
                this.mass = mass;
            }
        }
    }
}
