using System;
namespace Technology
{
    public class Computer : AbstractClass
    {
        public bool IsTurnedOn { get; set; }
        public double OSVersionNumber { get; set; }
        public readonly string OSName;

        public Computer(double osVersionNumber, string osName, bool isTurnedOn = false)
        {
            OSVersionNumber = osVersionNumber;
            this.OSName = osName;
            IsTurnedOn = isTurnedOn;
        }

        public double UpdateOSVersion(double newVersion)
        {
            return OSVersionNumber = newVersion;
        }

        public void TogglePower()
        {
            IsTurnedOn = !IsTurnedOn;
        }
    }
}

