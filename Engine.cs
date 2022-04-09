using System;
using System.Collections.Generic;
using System.Text;

namespace B5
{
    class Engine
    {
        // klasa reprezentujaca silnik statku

        // wlasciwosc - typ paliwa
        public string Fuel { get; private set; }

        // konstruktor ustawiajacy typ paliwa
        public Engine(string fuel)
        {
            if (fuel == "diesel" || fuel == "nuclear" || fuel == "hydrogen")
            {
                Fuel = fuel;
            }
            else
            {
                Console.WriteLine("Warning: unrecognized fuel option: " + fuel);
                Console.WriteLine("A diesel engine will be constructed instead.");
                Fuel = "diesel";
            }
        }

        // funkcja obliczajaca czas podrozy w zaleznosci od podanego dystansu i masy lodzi podwodnej
        // distance - podawany w km, mass - podawana w tonach, travelTime - zwracany w godzinach
        public int TravelTime(int distance, int mass)
        {
            int travelTime;
            switch (Fuel)
            {
                // tak bedzie dzialal nasz wymyslony silnik na diesel
                case "diesel":
                    if (mass < 10)
                    {
                        travelTime = distance / 60;
                    }
                    else if (mass < 40)
                    {
                        travelTime = distance / (60 - (mass - 10));
                    }
                    else
                    {
                        travelTime = distance / 30;
                    }
                    break;
                // teraz silnik jadrowy
                case "nuclear":
                    if (distance < 120)
                    {
                        travelTime = distance / 30;
                    }
                    else
                    {
                        if (mass < 50)
                        {
                            travelTime = (distance - 120) / 50 + 4;
                        }
                        else
                        {
                            travelTime = (distance - 120) / 40 + 4;
                        }
                    }
                    break;
                // i wreszcie wodorowy
                case "hydrogen":
                    int velocity = 600 / (10 + mass);
                    if (velocity < 20) velocity = 20;
                    travelTime = distance / velocity;
                    break;
                default:
                    travelTime = -1;
                    break;
            }
            return travelTime;
        }

        // metoda obliczajaca koszt podrozy dla tych samych parametrow
        public int TravelCost(int distance, int mass)
        {
            // koszt podrozy zalezy od czasu podrozy
            int cost;
            int time = TravelTime(distance, mass);
            // a takze od ceny danego paliwa
            switch (Fuel)
            {
                case "diesel":
                    cost = time * 100;
                    break;
                case "nuclear":
                    cost = time * 15;
                    break;
                case "hydrogen":
                    cost = time * 30;
                    break;
                default:
                    cost = -1;
                    break;
            }
            return cost;
        }
    }
}
