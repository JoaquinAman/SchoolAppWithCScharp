using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkManagerCourse.printer
{
    internal class OptionListStudents : IOption
    {
        private int _id;

        public OptionListStudents(int id)
        {
            _id = id;
        }

        public int MyId { get => _id; set => _id = value; }

        public int Execute(School school)
        {
            try
            {
                Console.WriteLine("Students list in course: " + school.Course[0].Name);
                
                Console.WriteLine("------------");

                foreach (Member member in school.Course[0].ListOfStudents)
                {
                    Console.WriteLine(member.Name + " " + member.LastName);
                }

                if (school.Course[0].ListOfStudents.Count == 0)
                {
                    Console.WriteLine("This course has no student registered.");
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("There are yet no courses created.");
            }
        
            Console.WriteLine("------------");
            

            IOption optionPrintMenu = new OptionPrintMenu(0);

            Printer printer = new Printer();

            printer.ListOfOptions.Add(optionPrintMenu);
            printer.printCommand(0, school);


            return 0;
        }
    }
}
