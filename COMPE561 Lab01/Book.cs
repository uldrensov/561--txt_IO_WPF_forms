﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMPE561_Lab01
{
    //class definition for the Book object
    class Book
    {
        //data fields
        public string title { get; set; }
        public string author { get; set; }
        public string isbn { get; set; }
        public string price { get; set; }


        //default constructor
        public Book()
        {
            title = "TITLE";
            author = "AUTHOR";
            isbn = "00000";
            price = "0";
        }


        //explicit value constructor
        public Book(string Title, string Author, string ISBN, string Price)
        {
            title = Title;
            author = Author;
            isbn = ISBN;
            price = Price;
        }


        //ToString method override
        public override string ToString()
        {
            return title;
        }
    }
}