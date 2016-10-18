using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code_first
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new School())
            {
                Student student = new Student()
                {
                    StudentName = "New student", StudentBirthDate = DateTime.Now.AddYears(-45)};
               
 ctx.Student.Add(student);
                ctx.SaveChanges();
            }
        }
    }

   
}
