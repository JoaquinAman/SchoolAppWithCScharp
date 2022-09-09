using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkManagerCourse
{
    internal class School
    {
        private List<Course> courseList = new List<Course>();
        private List<Member> memberList = new ();
        private List<Member> studentsList = new();
        public List<Course> Course { get { return courseList; } }
        public List<Member> Member { get { return memberList; } }
        public List<Member> Student { get { return studentsList; } }
        public School() { }
    }
}
