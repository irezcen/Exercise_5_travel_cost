using System;
using System.Collections.Generic;
using System.Text;

namespace zadanie_5
{
    class Destination
    {
        private string name;
        private int distance;
        public string Name
        {
            get
            {
                return name;
            }
        }
        public int Distance
        {
            get
            {
                return distance;
            }
        }
        public Destination( int distance, string name)
        {
            this.name = name;
            if (distance > 0)
            {
                this.distance = distance;
            }
            else
            {
                Console.WriteLine("dystans musi być liczbą dodatnią");
            }
        }
    }
}
