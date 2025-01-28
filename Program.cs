using System;

namespace bookStore
{
    class Book
    {
        private int v1;
        private string v2;

        private int _Id { get; set; }
        private string _Title { get; set; }
        private string _Author { get; set; }

        public Book()
        {
            _Id = 0;
            _Title = "";
            _Author = "";
        }

        public Book(int Id, string title, string author)
        {
            _Id = Id;
            _Author = author;
            _Title = title;
        }

        public Book(int v1, string v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }

        public string GetTitle()
        {
            return _Title;
        }
        public string GetAuthor()
        {
            return _Author;
        }
        public int GetId()
        {
            return _Id;
        }
        public void SetId(int Id)
        {
            _Id = Id;
        }
        public void SetTitle(string title)
        {
            _Title = title;
        }

        public void SetAuthor(string author)
        {
            _Author = author;
        }
        internal class Program
        {

            static void Main(string[] args)
            {

                Book title10 = new Book(10, "The Hobbit", "Tolkien");
                Console.WriteLine($"ID = {title10.GetId()}, BookName = {title10.GetTitle()}, Author = {title10.GetAuthor()}");


                Book title20 = new Book(20, "1984", "Orwell");
                Console.WriteLine($"ID = {title20.GetId()}, BookName = {title20.GetTitle()}, Author = {title20.GetAuthor()}");

                Book title30 = new Book();
                Console.WriteLine("Please enter the book ID");
                title30.SetId(int.Parse(Console.ReadLine()));
                Console.WriteLine("Please enter the book name");
                title30.SetTitle(Console.ReadLine());
                Console.WriteLine("Please enter the author's name");
                title30.SetAuthor(Console.ReadLine());
                Console.WriteLine("Thank you for your entry");

                Console.WriteLine("Please enter the book ID: ");
                int tempId = int.Parse(Console.ReadLine());
                Console.WriteLine("Please enter the book name: ");
                string tempTitle = Console.ReadLine();
                Console.WriteLine("Please enter the author's name: ");
                string tempAuthor = Console.ReadLine();
                Book title40 = new Book(tempId, tempTitle, tempAuthor);

                displayBooks(title10);
                displayBooks(title20);
                displayBooks(title30);
                displayBooks(title40);
            }
        }
        static void displayBooks(Book title)
        {
            
            Console.WriteLine($"ID: {title.GetId()}");
            Console.WriteLine($"BookName: {title.GetTitle()}");
            Console.WriteLine($"AuthorName: {title.GetAuthor()}");

            
        }
    }
}


    
