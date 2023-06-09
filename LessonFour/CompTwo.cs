﻿using System;
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
        public override bool Equals(object obj)
        {
            return this.ToString() == obj.ToString();
        }
        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }
        public static bool operator ==(Point p1, Point p2)
        {
            return p1.Equals(p2);
        }
        public static bool operator !=(Point p1, Point p2)
        {
            return !p1.Equals(p2);
        }
        public static bool operator >(Point p1, Point p2)
        {
            return Math.Sqrt(p1.X * p1.X + p1.Y * p1.Y) > Math.Sqrt(p2.X * p2.X + p2.Y * p2.Y);
        }
        public static bool operator <(Point p1, Point p2)
        {
            return Math.Sqrt(p1.X * p1.X + p1.Y * p1.Y) < Math.Sqrt(p2.X * p2.X + p2.Y * p2.Y);
        }
        public override string ToString()
        {
            return $"Point: X = {X}, Y = {Y}";
        }
    }
    

    internal class CompTwo
    {
        static void Main(string[] args)
        {
            Point p1 = new Point { X = 10, Y = 10 };
            Point p2 = new Point { X = 20, Y = 20 };
            WriteLine($"Point 1: {p1}");
            WriteLine($"Point 2: {p2}");
            WriteLine($"p1 == p2: {p1 == p2}");
            WriteLine($"p1 != p2: {p1 != p2}");
            WriteLine($"p1 > p2: {p1 > p2}");
            WriteLine($"p1 < p2: {p1 < p2}");
        }
    }
}
