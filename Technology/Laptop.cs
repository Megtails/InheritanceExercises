using System;
namespace Technology
{
    public class Laptop : Computer
    {
        public double Storage { get; set; }

        public Laptop(double osVersionNumber, string osName, double storage, bool isTurnedOn) : base(osVersionNumber, osName, isTurnedOn)
        {
            Storage = storage;

        }

        public double IncreaseStorage(double extraStorage)
        {
            return Storage += extraStorage;
        }
    }
}

