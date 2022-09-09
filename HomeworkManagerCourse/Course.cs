using HomeworkManagerCourse.printer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HomeworkManagerCourse
{
    internal struct Course
    {
        private string _courseName;
        private Member _trainer;
        private Member _manager;
        private List<Member> _listOfStudents = new();

        public List<Member> ListOfStudents { 
            get { return _listOfStudents; } 
        }
        public string Name { get { return _courseName; } }
        public Course(string courseName, Member trainer, Member manager)
        {
            _courseName = courseName;
            _trainer = trainer;
            _manager = manager;
        }
        public void PrintListOfStudents(string courseName)
        {
            Console.WriteLine("Course name = " + courseName);
            int counter = 1;
            foreach (var student in _listOfStudents) { 
                Console.WriteLine("Student " + counter + " = " +  student.Name + " " + student.LastName);
                counter++;
            }

        }
    }
}
