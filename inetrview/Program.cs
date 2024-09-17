using System;
using System.Collections.Generic;
namespace inetrview
{
    class Program
    {
        static void Main(string[] args)
        {
            Book b1 = new Book();
            bool books = true;
            //do while loop to ensure that the code runs at least once
            do
            {
                //prompting user to input an option (add,view,update,delete,exit)
                Console.WriteLine("Enter 1 to add new book\nEnter 2 to view books\nEnter 3 to edit book:");
                int opt = Convert.ToInt32(Console.ReadLine());

                if (opt == 1)
                {
                    b1.addBook();

                }   
                else
                {
                    Console.WriteLine("You have entered an invalid option!");
                    continue;
                }
                //asking the user if he/she want to continue or exit the app
                Console.WriteLine("Enter Y to continue or enter N to exit app");
                var proceed = Console.ReadLine();
                if (proceed.ToUpper() == "Y")
                {
                    books = true;
                }
                else
                {
                    books = false;
                }
            }
            while (books);
        }
    }
    class Book
    {
        string title;
        string author;
        string pyear;
        string ID;
        Dictionary<string, Array> book ;
        List<Array> books = new List<Array>();
        //func to add new book
        public void addBook()
        {
            Console.WriteLine("Enter book ID:");
             this.ID = Console.ReadLine();
            
            Console.WriteLine("Enter book title:");
            this.title = Console.ReadLine();

            Console.WriteLine("Enter book author:");
            this.author = Console.ReadLine();

            Console.WriteLine("Enter book publication year:");
            this.pyear = Console.ReadLine();
            book = new Dictionary<string, Array>();
            string[] bookDetails = { this.title, this.author, this.pyear };
            book.Add(this.ID, bookDetails);
            

            

        }
         /*public void editBook() {
            Console.WriteLine("Enter 1 to edit title\nEnter 2 to edit author\nEnter 3 to edit Publication year");
            int opt = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter new value for the book");
            string newValue = Console.ReadLine();
            if (opt == 1)
            {
                book["title"] = newValue;
            }
            else if (opt == 2)
            {
                book["author"] = newValue;
            }
            else if (opt == 3)
            {
                book["year"] = newValue;
            }
            else
            {
                return;
            }    
        }*/
        
     
   
    }

}
