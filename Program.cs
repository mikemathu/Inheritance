using Inheritance;

namespace Inheritance
{
    //Base Class
    class Polygon
    {
        static void Main()
        {
            //Polygon polygon = new Polygon(5);
            //Square square = new Square(4.5f);

            Polygon polygon = new Square(4.5f);

            //Checking an Object type and casting
            if(polygon is Square)
            {
                Square square = (Square)polygon;
            }

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