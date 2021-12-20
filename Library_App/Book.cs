using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_App
{
    public class Book
    {
        string name;
        string writer;
        int numOfPages;

        public string Name { get; set; }
        public string Writer { get; set; }
        public int NumOfPages { get; set; }

        public Book() { }
        public Book(string name, string writer, int numOfPages)
        {
            Name = name;
            Writer = writer;
            NumOfPages = numOfPages;
        }
    }
}
