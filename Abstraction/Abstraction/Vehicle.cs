using System;
using System.Collections.Generic;

namespace Abstraction
{
    public abstract class Vehicle
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int TopSpeedKmh { get; set; }

        public Vehicle(string brand, string model, int topSpeedKmh)
        {
            Brand = brand;
            Model = model;
            TopSpeedKmh = topSpeedKmh;
        }

        public void Start()
        {
            Console.WriteLine($"{Brand} {Model} starter motoren.");
        }

        // "virtual" betyder: afledte klasser MÅ gerne give deres egen
        // implementering af denne metode via "override".
        public virtual string Description()
        {
            return $"{Brand} {Model}, topfart {TopSpeedKmh} km/t";
        }

        public abstract decimal BeregnAarsafgift();
    }
}
