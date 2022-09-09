using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkManagerCourse.printer
{
    internal class OptionPrintMenu : IOption
    {
        private int _id;
        public OptionPrintMenu(int id)
        {
            _id = id;
        }
        public int MyId { get => _id; set => _id = value; }

        public int Execute(School school)
        {
            Console.WriteLine("Select the task you want to do:");
            Console.WriteLine("1. Create course.");
            Console.WriteLine("2. Create and add student.");
            Console.WriteLine("3. Print member information.");
            Console.WriteLine("4. Print list of students information.");
            Console.WriteLine("5. Close application.");
            int selectedOption = Int32.Parse(Console.ReadLine());


            IOption optionPrintMenu = new OptionPrintMenu(0);
            IOption optionCreateCourse = new OptionCreateCourse(1);
            IOption optionCreateStudent = new OptionCreateStudent(2);
            IOption optionMemberInformation = new OptionMemberInformation(3);
            IOption optionListStudents = new OptionListStudents(4);
            IOption optionCloseApp = new OptionCloseApp(5);

            Printer printer = new Printer();

            printer.ListOfOptions.Add(optionPrintMenu);
            printer.ListOfOptions.Add(optionCreateCourse);
            printer.ListOfOptions.Add(optionCreateStudent);
            printer.ListOfOptions.Add(optionMemberInformation);
            printer.ListOfOptions.Add(optionListStudents);
            printer.ListOfOptions.Add(optionCloseApp);

            printer.printCommand(selectedOption, school);

            return selectedOption;
        }
    }
}
