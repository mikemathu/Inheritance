using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
     class Square : Polygon
    {
        public float Size { get; set; }

        public Square(float size) : base(4)//Use the Polygon(int numberOfSides) constructor in the base class
        {
            Size = size;
            NumberOfSides= 4;

            Console.WriteLine("The sides of the square are "+ Size);
        }
    }
}
