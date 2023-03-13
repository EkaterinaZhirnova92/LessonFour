using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace HomeWork
{
    class Book
    {
        public string Author { get; set; }
        public string NameBook { get; set; }

        public override string ToString()
        {
            return $"Автор: {Author} Название: {NameBook} \n";
        }
    }

    enum Authors { Tolstoy, Dostoevski, Bulgakov };

    class BookList
    {
        Book[] bookArr;

        public BookList(int size)
        {
            bookArr = new Book[size];
        }

        public int Length
        {
            get { return bookArr.Length; }
        }

        public Book this[int index]
        {
            get
            {
                if (index >= 0 && index < bookArr.Length)
                {
                    return bookArr[index];
                }
                throw new IndexOutOfRangeException();
            }
            set
            {
                bookArr[index] = value;
            }
        }

        public Book this[string name]
        {
            get
            {
                if (Enum.IsDefined(typeof(Authors), name))
                {
                    return bookArr[(int)Enum.Parse(typeof(Authors), name)];
                }
                else
                {
                    return new Book();
                }
            }
            set
            {
                if (Enum.IsDefined(typeof(Authors), name))
                {
                    bookArr[(int)Enum.Parse(typeof(Authors), name)] = value;
                }
            }
        }

        public int FindByAuthor(string author)
        {
            for (int i = 0; i < bookArr.Length; i++)
            {
                if (bookArr[i].Author == author)
                {
                    return i;
                }
            }
            return -1;
        }

    }

    class Indeksators
    {
        static void Main(string[] args)
        {
            BookList books = new BookList(3);
            books[0] = new Book
            {
                Author = "Bulgakov",
                NameBook = "Master and Margarita"
            };
            books[1] = new Book
            {
                Author = "Dostoevski",
                NameBook = "Idiot",
            };
            books[2] = new Book
            {
                Author = "Tolstoy",
                NameBook = "War and Peace",
            };


            try
            {
                for (int i = 0; i < books.Length; i++)
                {
                    WriteLine(books[i]);
                }
                WriteLine();

                WriteLine($"{books["Tolstoy"]}");
                WriteLine($"{books["Dostoevski"]}");
                WriteLine($"{books["Bulgakov"]}");
                WriteLine($"{books["Esenin"]}");

            }
            catch (Exception ex)
            {
                WriteLine(ex.Message);
            }
        }
    }
}
