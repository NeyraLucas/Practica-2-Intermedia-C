using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2
{
    internal class Maths
    {
        public string numberX;
        public string numberY;

        public  Maths(string numberX, string numberY)
        {
            this.numberX = numberX;
            this.numberY = numberY;
        }

        ///Implicit
        ///
        public static implicit operator Maths(Bird bird) => new Bird(bird.name, bird.color);

              


    }
}
