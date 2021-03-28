using System;

namespace Singleton
{
    class Bike
    {
        private Bike()
        {

        }
        private static Bike obj;
        private static Bike GetInstance()
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
        static void Main(string[] args)
        {
            Bike bike = Bike.GetInstance();
            string x = bike.getDetails();
            Console.WriteLine(x);
            Console.ReadLine();
        }
    }
}
