using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Car myCar = new Car();
            myCar.driveCar();
            myCar.PrintCarInfo();
            Garage.AddCarToGarage(myCar);

            Console.Read();

        }
    }
    

}
