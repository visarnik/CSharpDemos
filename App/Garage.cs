using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
      class Garage
    {
        static List<Car> Fleet = new List<Car>();

        public static void AddCarToGarage(Car car)
        {
            Fleet.Add(car);

        }
        
    }
}
