using System;

namespace project
{
    struct Book
    {
        private string title, author, subject;
        private short pages;

        public void SetValues(string title, string author )
        {
            this.title = title;
            this.author = author;
           
           
        }
        public void printValues()
        {
            Console.WriteLine("Title: " + title);
            Console.WriteLine("Author: " + author);
          
          
        }
    }
}