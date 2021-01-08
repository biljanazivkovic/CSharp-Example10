using System;

namespace ex10
{
    class Bike
    {
        string color = "blue";
        static void Main(string[] args)
        {
            Car myCar = new Car();
            Bike myBike = new Bike();
            Console.WriteLine(myCar.color);
            Console.WriteLine(myBike.color);
        }
    }
}
