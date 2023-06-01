using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.HelperClass
{
    public class EmployeeClass
    {
        public string FName { get; set; }
        public string LName { get; set; }
        public string Post { get; set; }

        public static List<EmployeeClass> EmployeeClasses = new List<EmployeeClass>();
    }
}
