using System;
namespace Technology
{
    public class SmartPhone : Computer
    {
        public double PhoneNumber {get; set;}
        public string Message = "Empty Message";


        public SmartPhone(double osVersionNumber, string osName, double phoneNumber, bool isTurnedOn) : base(osVersionNumber, osName, isTurnedOn)
        {
            PhoneNumber = phoneNumber;
        }

        public string Text(string message, double phoneNumber)
        {
            if (PhoneNumber == phoneNumber)
            {
                Console.WriteLine(message);
                return Message = message;
            }
            else
            {
                Console.WriteLine("Invalid number, try again.");
                return "Invalid number, try again.";
            }
        }

    }
}

