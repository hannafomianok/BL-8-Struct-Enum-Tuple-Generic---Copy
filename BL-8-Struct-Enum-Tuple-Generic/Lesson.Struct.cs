using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL_8_Struct_Enum_Tuple_Generic
{
    partial class Lesson
    {
        public static void StructExample()
        {
            Coordinate coord0 = new Coordinate(0, 0);
            Coordinate coord1;
            Coordinate coord2;

            coord1.x = 15;
            coord1.y = 15;
            

            coord2 = coord1;
            coord2.y = 10;
            Console.WriteLine(coord2.y);
            Console.WriteLine(coord2.y);
        }
    }

    public struct Color
    {
        public string rgb;
        public string name;
    }

    public struct Coordinate
    {
        public int x;
        public int y;


        public Coordinate(int x, int y)
        {
            this.x = x;
            this.y = y;

        }

        public double Lenght
        {
            get { return Vector(); }
        }

        public double Vector()
        {
            var length = Math.Sqrt(x*x+y*y);

            return length;
        }
    }
}
