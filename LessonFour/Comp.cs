using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


//синтаксис методов сравнения объектов
//сравнение ссылок
//public static bool ReferenceEquals(Object obj1, Object obj2) {}
//сравнение значений
//public bool virtual Equals(Object obj) {}

namespace LessonFour
{
    class CPoint
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
    struct SPoint
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
    
    internal class Comp
    {
        static void Main(string[] args)
        {
            CPoint cp = new CPoint { X = 10, Y = 10 };
            CPoint cp1 = new CPoint { X = 10, Y = 10 };
            CPoint cp2 = cp1;
            //работа метода referenceEquals() со ссылочными типами
            WriteLine($"ReferenceEquals(cp, cp1) = {ReferenceEquals(cp, cp1)}");
            WriteLine($"ReferenceEquals(cp1, cp2) = {ReferenceEquals(cp1, cp2)}");
            SPoint sp = new SPoint { X = 10, Y = 10};
            //работа метода referenceEquals() со значимыми типами
            WriteLine($"ReferenceEquals(sp, sp) = {ReferenceEquals(sp, sp)}");
            //работа метода Equals() со ссылочными типами
            WriteLine($"Equals(cp, cp1) = {Equals(cp, cp1)}");
            //работа метода Equals() со значимыми типами
            SPoint sp1 = new SPoint { X = 10, Y = 10 };
            WriteLine($"Equals(sp, sp1) = {Equals(sp, sp1)}");
        }
    }
}
