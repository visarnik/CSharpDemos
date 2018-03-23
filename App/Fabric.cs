

namespace App
{
    using System;
    using System.Collections.Generic;

    public static class Fabric
    {

        private static string model;
        private static int speed;
        private static int power;
         
        public static void MakeNewCar()
        {
            Console.WriteLine("Input new car details");
            model = Console.ReadLine();
            speed = int.Parse(Console.ReadLine());
            power = int.Parse(Console.ReadLine());
            Garage.AddCarToGarage(new Car(model, speed, power));
            Console.WriteLine("Your car ID is:"+ (Garage.Fleet.Count -1));
        }
        
    }
}
