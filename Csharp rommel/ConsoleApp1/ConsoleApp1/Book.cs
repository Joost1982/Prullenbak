using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Book
    {
        public string Titel { get; private set; }
        public string Auteur { get; }
        public int Paginas { get; }

        public static int bookCount = 0 ; // static attribute, hoort bij de class in general en niet bij het object

        //constructor
       public Book(string titel, string auteur, int paginas)
       {
           Titel = titel;
           Auteur = auteur;
           Paginas = paginas;

            bookCount++;
        }

       // je kan meerdere constructors hebben
       // je kan er ook nog eentje hebben zonder parameters, zodat je
       // Book bookx = new Book(); kan blijven doen

        public Book()
        {

        }


    }

}
