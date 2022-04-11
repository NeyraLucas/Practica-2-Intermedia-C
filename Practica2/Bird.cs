using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2
{
    internal class Bird
    {
        public string name;
        public string color;

        public Bird(string name, string color)
        {
            this.name = name;
            this.color = color;
        }

        ///Implicit
        ///
        public static implicit operator Bird(Maths maths) => new Maths(maths.numberX, maths.numberY);
    }
}
