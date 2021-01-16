using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    interface IBook
    {
        string this[int index]
        {
            get;
            set;
        }
        string Title
        {
            get;
            set;
        }
        string Author
        {
            get;
            set;
        }
        string Publisher
        {
            get;
            set;
        }
        string ISBN
        {
            get;
            set;
        }
        int Year
        {
            get;
            set;
        }
        void Show();
    }
    public class Book : IBook
    {

        #region Định nghĩa dữ liệu
        private string isbn;
        private string title;
        private string author;
        private string publisher;
        private int year;
        private ArrayList chapter = new ArrayList();

        public Book() {  }
        public Book(string isbn, string title, string author, string publisher,int year)
        {
            this.isbn = isbn;
            this.title = title;
            this.author = author;
            this.publisher = publisher;
            this.year = year;
        }

        #endregion
        #region Thực thi giao diện IBook
        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < chapter.Count)
                    return (string)chapter[index];
                else
                    throw new IndexOutOfRangeException();
            }
            set
            {
                if (index >= 0 && index < chapter.Count)
                    chapter[index] = value;
                else if (index == chapter.Count)
                {
                    chapter.Add(value);
                }
                else
                    throw new IndexOutOfRangeException();
            }
        }
        public string Title { get => title; set => title = value; }
        public string Publisher { get => publisher; set => publisher = value; }
        public string Author { get => author; set => author = value; }
        public string ISBN { get => isbn; set => isbn = value; }
        public int Year { get => year; set => year = value; }
        public void Show()
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine("Title: " + title);
            Console.WriteLine("Author: " + author);
            Console.WriteLine("Publisher: " + publisher);
            Console.WriteLine("Year: " + year);
            Console.WriteLine("ISBN: " + isbn);
            Console.WriteLine("Chapter: ");
            for (int i = 0; i < chapter.Count; i++)
                Console.WriteLine("\t{0} : {1}", i + 1, chapter[i]);
            Console.WriteLine("-------------------------");
        }
        public void Input()
        {
            Console.WriteLine("Title: ");
            title = Console.ReadLine();
            Console.WriteLine("Author: ");
            author = Console.ReadLine();
            Console.WriteLine("Publisher: ");
            publisher = Console.ReadLine();
            Console.WriteLine("ISBN: ");
            isbn = Console.ReadLine();
            Console.WriteLine("Year: ");
            year = int.Parse(Console.ReadLine());
            Console.WriteLine("Input chapter (finish with empty string)");
            string str;
            do
            {
                str = Console.ReadLine();
                if (str.Length > 0)
                    chapter.Add(str);
            } while (str.Length > 0);
        }
        #endregion
    }
}
