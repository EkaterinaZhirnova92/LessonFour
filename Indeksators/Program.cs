using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace Indeksators
{
    class Laptop
    {
        public string Brand { get; set; }
        public double Price { get; set; }

        public override string ToString()
        {
            return $"{Brand} {Price} $\n";
        }
    }

    enum Brands { Macbook, Asus, Honor };

    class Shop
    {
        Laptop[] laptopArr;

        public Shop(int size)
        {
            laptopArr = new Laptop[size];
        }

        public int Length
        {
            get { return laptopArr.Length; }
        }

        public Laptop this[int index]
        {
            get
            {
                if (index >= 0 && index < laptopArr.Length)
                {
                    return laptopArr[index];
                }
                throw new IndexOutOfRangeException();
            }
            set
            {
                laptopArr[index] = value;
            }
        }

        public Laptop this[string name]
        {
            get
            {
                if (Enum.IsDefined(typeof(Brands), name))
                {
                    return laptopArr[(int)Enum.Parse(typeof(Brands), name)];
                }
                else
                {
                    return new Laptop();
                }
            }
            set
            {
                if (Enum.IsDefined(typeof(Brands), name))
                {
                    laptopArr[(int)Enum.Parse(typeof(Brands), name)] = value;
                }
            }
        }

        public int FindByPrice(double price)
        {
            for (int i = 0; i < laptopArr.Length; i++)
            {
                if (laptopArr[i].Price == price)
                {
                    return i;
                }
            }
            return -1;
        }

        public Laptop this[double price]
        {
            get
            {
                if (FindByPrice(price) >= 0)
                {
                    return this[FindByPrice(price)];
                }
                throw new Exception("Недопустимая стоимость");
            }
            set
            {
                if (FindByPrice(price) >= 0)
                {
                    this[FindByPrice(price)] = value;
                }
            }
        }

    }

    class Indeksators
    {
        static void Main(string[] args)
        {
            Shop laptops = new Shop(3);
            laptops[0] = new Laptop
            {
                Brand = "Macbook",
                Price = 1300
            };
            laptops[1] = new Laptop
            {
                Brand = "Asus",
                Price = 1000
            };
            laptops[2] = new Laptop
            {
                Brand = "Honor",
                Price = 900
            };

            try
            {
                for (int i = 0; i < laptops.Length; i++)
                {
                    WriteLine(laptops[i]);
                }
                WriteLine();

                WriteLine($"Производитель Macbook: {laptops["Macbook"]}");
                WriteLine($"Производитель Asus: {laptops["Asus"]}");
                WriteLine($"Производитель Honor: {laptops["Honor"]}");

                WriteLine($"Стоимость 1300: {laptops[1300.0]}");
                WriteLine($"Стоимость 900: {laptops[900.0]}");
                WriteLine($"Стоимость 100000: {laptops[100000.0]}");
            }
            catch (Exception ex)
            {
                WriteLine(ex.Message);
            }
        }
    }
}
