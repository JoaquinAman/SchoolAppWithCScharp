using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HomeworkManagerCourse.printer
{
    internal class OptionCreateCourse : IOption
    {
        private int _id;

        public OptionCreateCourse(int id) 
        {
            _id = id;
        }

        public int MyId { get => _id; set => _id = value; }

        public int Execute(School school)
        {
            
            Console.WriteLine("Trainer: ");
            Console.WriteLine("Name: ");
            string trainerName = Console.ReadLine();
            Console.WriteLine("Lastname: ");
            string trainerLastName = Console.ReadLine();
            Console.WriteLine("Email: ");
            string trainerEmail = Console.ReadLine();
            Console.WriteLine("Rol: ");
            string trainerRol = Console.ReadLine();
            Member trainerMember = new(trainerName, trainerLastName, trainerEmail, trainerRol);

            Console.WriteLine("------------------");

            Console.WriteLine("Manager: ");
            Console.WriteLine("Name: ");
            string managerName = Console.ReadLine();
            Console.WriteLine("Lastname: ");
            string managerLastName = Console.ReadLine();
            Console.WriteLine("Email: ");
            string managerEmail = Console.ReadLine();
            Console.WriteLine("Rol: ");
            string managerRol = Console.ReadLine();
            Member managerMember = new(managerName, managerLastName, managerEmail, managerRol);

            Course course = new("courseName", trainerMember, managerMember);

            school.Course.Add(course);


            IOption optionPrintMenu = new OptionPrintMenu(0);
            
            Printer printer = new Printer();

            printer.ListOfOptions.Add(optionPrintMenu);
            printer.printCommand(0, school);


            return 0;
        }
    }
}
