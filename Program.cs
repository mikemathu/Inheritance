﻿using Inheritance;

namespace Inheritance
{
    //Base Class
    class Polygon
    {
        static void Main()
        {
            Polygon polygon = new Polygon(5);
            //Square square = new Square(4.5f);

            /*
            Polygon polygon = new Square(4.5f);

            //Checking an Object type and casting
            
            if(polygon is Square)
            {
                Square square = (Square)polygon;

                Console.WriteLine("I am a Square now");
            }
            */

            //The AS keyword
            /*
            Polygon polygon = new Square(4);
            Square square = polygon as Square;

            if (square != null)
            {
                Console.WriteLine("Square is not null");
            }
            */

            //Using Inheritance in Arrays
            /*
            Polygon[] lotsOfPolygon = new Polygon[5];
            lotsOfPolygon[2] = new Square(2.1f);
            //lotsOfPolygon[3] = new Triangle();
            Console.WriteLine(lotsOfPolygon[1]);
            */
            

        }
        public int NumberOfSides { get; set; }

        public Polygon()
        {
            NumberOfSides = 0;
        }
        public Polygon(int numberOfSides)
        {
            NumberOfSides = numberOfSides;

            Console.WriteLine(NumberOfSides);
        }
    }
}