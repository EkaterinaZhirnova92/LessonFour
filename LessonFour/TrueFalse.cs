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
            return p.X !=0 || p.Y !=0 ? true : false;
        }
        public static bool operator false(Point p)
        {
            return p.X == 0 && p.Y == 0 ? true : false;
        }
        public override string ToString()
        {
            return $"Point: X = {X}, Y = {Y}";
        }
    }


    internal class TrueFalse
    {
        static void Main(string[] args)
        {
            WriteLine("Введите координаты точки на плоскости: ");
            Point point = new Point
            {
                X = int.Parse(ReadLine()),
                Y = int.Parse(ReadLine())
            };
            if(point)
            {
                WriteLine("Точка не в начале координат");
            }
            else
            {
                WriteLine("Точка в начале координат");
            }
        }
    }
}
