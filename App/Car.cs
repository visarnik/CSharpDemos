using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    class Car : IBaseCar
    {
        private int hp;

        public int HP
        {
            get { return hp; }
            set { hp = value; }
        }
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Manufacture { get ; set; }
        public string Model { get; set; }
        public int Size { get; set; }
    }
}
