using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace HomeWork
{

    class Journal
    {
        public string JournalName { get; set; } = "Example name";
        public int Year { get; set; } = 1990;
        public string Email { get; set; } = "Example@mail.ru";
        public int NumberOfWorkers { get; set; }
        public static Journal operator --(Journal item)
        {
            item.NumberOfWorkers--;
            return item;
        }
        public static Journal operator ++(Journal item)
        {
            item.NumberOfWorkers++;
            return item;
        }
        public static Journal operator +(Journal item, int n)
        {
            item.NumberOfWorkers +=n;
            return item;
        }
        public static Journal operator -(Journal item, int n)
        {
            item.NumberOfWorkers -= n;
            return item;
        }
        public static bool operator >(Journal j1, Journal j2)
        {
            return j1.NumberOfWorkers > j2.NumberOfWorkers;
        }
        public static bool operator <(Journal j1, Journal j2)
        {
            return j1.NumberOfWorkers < j2.NumberOfWorkers;
        }
        public override bool Equals(object obj)
        {
            return this.ToString() == obj.ToString();
        }
        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }
        public static bool operator ==(Journal j1, Journal j2)
        {
            return j1.NumberOfWorkers.Equals(j2.NumberOfWorkers);
        }
        public static bool operator !=(Journal j1, Journal j2)
        {
            return !j1.NumberOfWorkers.Equals(j2.NumberOfWorkers);
        }
        public override string ToString()
        {
            return $"\tНазвание журнала: {JournalName}\n\tГод основания: {Year}\n\tEmail для связи: {Email}\n\tКоличество сотрудников: {NumberOfWorkers}\n";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            ForegroundColor = ConsoleColor.Red;
            BackgroundColor = ConsoleColor.White;
            Clear();
            WindowWidth = 70;
            WindowHeight = 30;


            Journal murzilka = new Journal
            {
                JournalName = "Мурзилка",
                Year = 1924,
                Email = "Murzilka@mail.ru",
                NumberOfWorkers = 10
            };

            Journal OK = new Journal
            {
                JournalName = "OK",
                Year = 1950,
                Email = "OK@mail.ru",
                NumberOfWorkers = 20
            };

            WriteLine(murzilka);
            WriteLine(OK);
            murzilka.NumberOfWorkers++;
            WriteLine(murzilka);
            murzilka.NumberOfWorkers += 3;
            WriteLine(murzilka);
            WriteLine($"\tworkers of murzilka > workers of OK: {murzilka.NumberOfWorkers > OK.NumberOfWorkers}");
            WriteLine($"\tworkers of murzilka < workers of OK: {murzilka.NumberOfWorkers < OK.NumberOfWorkers}");
            WriteLine($"\tworkers of murzilka = workers of OK: {murzilka.NumberOfWorkers == OK.NumberOfWorkers}");
            WriteLine($"\tworkers of murzilka != workers of OK: {murzilka.NumberOfWorkers != OK.NumberOfWorkers}");
            WriteLine($"\tEquals(workers of murzilka, workers of OK): {Equals(murzilka.NumberOfWorkers, OK.NumberOfWorkers)}");
        }
    }
}

