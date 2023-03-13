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

        public static Point operator ++(Point s)
        {
            s.X++;
            s.Y++;
            return s;
;
        }
        public static Point operator --(Point s)
        {
            s.X--;
            s.Y--;
            return s;
            ;
        }
        public static Point operator -(Point s)
        {
            return new Point { X = -s.X, Y = -s.Y };
        }
        public override string ToString()
        {
            return $"Point: X = {X}, Y = {Y}";
        }
    }
    internal class Overload
    {
        static void Main(string[] args)
        {
            Point point = new Point { X = 10, Y = 10 };
            WriteLine($"Исходная точка: {point}");
            WriteLine($"Постфиксная и префиксная формы выполняются одинаково");
            WriteLine(++point);
            WriteLine(point++);
            WriteLine("Префиксная форма декремента: ");
            WriteLine(--point);
            WriteLine("Пoctфиксная форма декремента: ");
            WriteLine(point--);
            WriteLine($"Выполнение оператора - \n {-point} не изменило исходную точку {point}");

        }
    }
}
