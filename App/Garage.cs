using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
      public static class Garage
    {
        public static List<Car> Fleet = new List<Car>();

        

        public static void AddCarToGarage(Car car)
        {
            Fleet.Add(car);
            Fleet.Last<Car>();
        }
        
        public static void ShowAllCarsFromGarage()
        {
            Fleet.ForEach(x=> Console.WriteLine($"{x.Model}, {x.Speed}, {x.Power}"));
            
        }
    }
    
}
