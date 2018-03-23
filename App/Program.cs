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
            
            int key;
            do
            {
                Console.WriteLine("For Exit press 5 \nTo See all of your cars press 1\nTo create new car press 6");
                key = int.Parse(Console.ReadLine());
                if (key == 6)
                {
                    Console.Clear();
                    Fabric.MakeNewCar();
                    
                }
                if (key == 1)
                {
                    Console.Clear();
                    Garage.ShowAllCarsFromGarage();

                }
            } while (key != 5);
        }
    }
    

}
