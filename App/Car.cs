using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
   public class Car : ICar
    {
        public string Model { get; set; }
        public int Power { get; set; }
        public string Color { get; set; }
        public int Speed { get; set; }

        public Car (string model, int speed, int power)
        {
            this.Model = model;
            this.Speed = speed;
            this.Power = power;
        }

        public Car()
        {

        }
        public void PrintCarInfo()
        {
            Console.WriteLine($"{this.Model}, {this.Speed}, {this.Power}");
        }
    }
}
