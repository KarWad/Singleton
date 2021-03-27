using System;

namespace Singleton
{
    class Bike
    {
        private Bike()
        {

        }
        public static Bike obj;
        public static Bike GetInstance()
        {
            if (obj == null)
            {
                obj = new Bike();
            }
            return obj;
        }
        public string getDetails()
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
