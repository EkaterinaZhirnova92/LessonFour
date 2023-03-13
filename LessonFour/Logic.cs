using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace LessonFour
{
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public static bool operator true(Point p)
        {
            return p.X != 0 || p.Y != 0 ? true : false;
        }
        public static bool operator false(Point p)
        {
            return p.X == 0 && p.Y == 0 ? true : false;
        }
        public static Point operator &(Point p1, Point p2)
        {
            if((p1.X != 0 && p1.Y != 0) && (p2.X != 0 && p2.Y !=0))
            {
                return p2;
            }
            return new Point();
        }
        public static Point operator |(Point p1, Point p2)
        {
            if ((p1.X != 0 || p1.Y != 0) || (p2.X != 0 || p2.Y != 0))
            {
                return p2;
            }
            return new Point();
        }
        public override string ToString()
        {
            return $"Point: X = {X}, Y = {Y}";
        }
    }


    internal class Logic
    {
        static void Main(string[] args)
        {
            Point p1 = new Point { X = 10, Y = 10 };
            Point p2 = new Point { X = 0, Y = 0 };
            WriteLine($"p1: {p1}");
            WriteLine($"p2: {p2}");
            Write("p1 && p2: ");
            if(p1 && p2)
            {
                WriteLine("True");
            }
            else
            {
                WriteLine("False");
            }
            Write("p1 || p2: ");
            if (p1 || p2)
            {
                WriteLine("True");
            }
            else
            {
                WriteLine("False");
            }
        }
    }
}
