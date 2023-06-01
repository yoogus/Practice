using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice15
{
    public class Program
    {
        static void Main(string[] args)
        {

            StudentAddClass student1 = new StudentAddClass("Саша", "3ИСП9-18вб", "09.10.2004");
            StudentAddClass student2 = new StudentAddClass("Гоша", "3ИСП9-18вб", "15.02.2005");
            StudentAddClass student3 = new StudentAddClass("Гриша", "3ИСП9-18вб", "19.12.2005");

            student1.AddStudent(student1);
            student1.AddStudent(student2);
            student1.AddStudent(student3);

            List<StudentAddClass> allStudents = student1.GetStudents();

            foreach (var student in allStudents)
            {
                student.infoForNewStudents();
            }
            Console.ReadKey();
        }
    }
}
