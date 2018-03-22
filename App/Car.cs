using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    class Car : ICar
    {
        public string Model { get; set; }
        public int Power { get; set; }
        public string Color { get; set; }
        public int Speed { get; set; }

        public Car()
        {
            this.Model = "BMW";
            this.Speed = 100;
            this.Power = 120;
        }
        public void driveCar()
        {
            Speed++;
        }
        public void PrintCarInfo()
        {
            Console.WriteLine($"{this.Model}, {this.Speed}, {this.Power}");
        }
    }
}
