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
    }
    class Vector
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Vector() { }
        public Vector(Point begin, Point end)
        {
            X = end.X - begin.X;
            Y = end.Y - begin.Y;
        }
        public static Vector operator +(Vector v1, Vector v2)
        {
            return new Vector { X = v1.X + v2.X, Y = v1.Y + v2.Y };
        }
        public static Vector operator -(Vector v1, Vector v2)
        {
            return new Vector { X = v1.X - v2.X, Y = v1.Y - v2.Y };
        }
        public static Vector operator *(Vector v, int n)
        {
            v.X *= n;
            v.Y *= n;
            return v;
        }
        public override string ToString()
        {
            return $"Vector: X = {X}, Y = {Y}";
        }
    }

    internal class Binary
    {
        static void Main(string[] args)
        {
        Point p1 = new Point { X = 2, Y = 3 };
        Point p2 = new Point { X = 3, Y = 2 };

        Vector v1 = new Vector(p1, p2);
        Vector v2 = new Vector { X = 2, Y = 3 };
            WriteLine($"Вектор v1\n{v1}\nВектор v2\n{v2}");
            WriteLine($"Сложение векторов\n{v1 + v2}\n");
            WriteLine($"Разность векторов\n{v1 - v2}\n");
            WriteLine("Введите целое число: ");
            int n = int.Parse(ReadLine());
            WriteLine($"Умножение вектора на число {n}\n{v1 *= n}");

        }
    }
}
