using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    class Car : ICar
    {
        public string Model { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Power { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Color { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Speed { get; set; }
        public void driveCar()
        {
            Speed++;
        }
    }
}
