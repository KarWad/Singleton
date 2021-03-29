using System;

namespace Singleton
{
    class Bike
    {
        private Bike()
        {

        }
        private static Bike obj;
        public static Bike GetInstance()
        {
            if (obj == null)
            {
                obj = new Bike();
            }
            return obj;
        }
        private string getDetails()
        {
            return "Winora";
        }
    }

    class program
    {
        static void Main(string[] args)
        {
            Bike b1 = Bike.GetInstance();
            Bike b2 = Bike.GetInstance();

            if (b1 == b2)
             {
                Console.WriteLine("Singleton works, both variables contain the same instance.");
            }
            else
            {
                Console.WriteLine("Singleton failed, variables contain different instances.");
            }
        }
    }
}
 