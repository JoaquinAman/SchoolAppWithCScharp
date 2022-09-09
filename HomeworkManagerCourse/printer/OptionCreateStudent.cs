using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkManagerCourse.printer
{
    internal class OptionCreateStudent : IOption
    {
        private int _id;

        public OptionCreateStudent(int id)
        {
            _id = id;
        }

        public int MyId { get => _id; set => _id = value; }

        public int Execute(School school)
        {

            Console.WriteLine("Student: ");
            Console.WriteLine("Student name: ");
            string studentName = Console.ReadLine();
            Console.WriteLine("Student lastname: ");
            string studentLastName = Console.ReadLine();
            Console.WriteLine("Student email: ");
            string studentEmail = Console.ReadLine();
            Console.WriteLine("Student rol: ");
            string studentRol = Console.ReadLine();
            Member studentMember = new(studentName, studentLastName, studentEmail, studentRol);

            school.Course[0].ListOfStudents.Add(studentMember);
            school.Member.Add(studentMember);
            school.Student.Add(studentMember);


            IOption optionPrintMenu = new OptionPrintMenu(0);

            Printer printer = new Printer();

            printer.ListOfOptions.Add(optionPrintMenu);
            printer.printCommand(0, school);


            return 0;
        }
    }
}
