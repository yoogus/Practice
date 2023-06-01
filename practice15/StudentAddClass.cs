using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice15
{
    public class StudentAddClass
    {
        private string _name;
        private string _group;
        private string _birthday;
        private List<StudentAddClass> allStudents;

        public StudentAddClass(string name, string group, string birthday)
        {
            _name = name;
            _group = group;
            _birthday = birthday;
            allStudents = new List<StudentAddClass>();
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Group
        {
            get { return _group; }
            set { _group = value; }
        }

        public string Birthday
        {
            get { return _birthday; }
            set { _birthday = value; }
        }

        public void AddStudent(StudentAddClass studentAddClass)
        {
            allStudents.Add(studentAddClass);
        }

        public void infoForNewStudents()
        {
            Console.WriteLine($"\nName: {_name} \nGroup: {_group} \nBirthDay: {_birthday}");
        }

        public List<StudentAddClass> GetStudents()
        {
            return allStudents;
        }
    }
}
