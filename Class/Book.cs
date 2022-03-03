using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    internal class Book
    {
        public string title;
        public string author;
        public int pages;

        public Book (string aTitle, string aAuthor, int Apages)
        {
            title = aTitle;
            author = aAuthor;
            pages = Apages;
        }
    }
}
