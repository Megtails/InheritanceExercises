using System;
namespace Technology
{
    public class AbstractClass
    {
        public int IDNumber { get; set; }
        private static int nextID = 1;

        public AbstractClass()
        {
            IDNumber = nextID;
            nextID++;
        }
    }
}

