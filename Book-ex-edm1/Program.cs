using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_ex_edm1
{
    class Program
    {
        static void Main(string[] args)
        {
            QAuthors();
        }
 private static void QAuthors()
    {
        using (var context = new BooksEntities())
        {
            var authors = context.Authors;
            foreach(var author in authors)
            {
                Console.WriteLine("Author name {0} och author id {1}", author.FirstName.Trim(),
                                       author.AuthorID);
            }
            Console.WriteLine("Press enter");
            Console.ReadLine();
        }
    }
    }
   
}
