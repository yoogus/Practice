using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.HelperClass
{
    public class EmployeeViewModel
    {
        public ObservableCollection<EmployeeClass> EmployeeClasses { get; set; }

        public EmployeeViewModel()
        {
            EmployeeClasses = new ObservableCollection<EmployeeClass>();
        }

        public void AddEmployee(string firstName, string lastName, string post)
        {
            EmployeeClass employee = new EmployeeClass
            {
                FName = firstName,
                LName = lastName,
                Post = post
            };

            EmployeeClasses.Add(employee);
        }
    }
}
