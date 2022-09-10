using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkManagerCourse.printer
{
    internal class OptionMemberInformation : IOption
    {
        private int _id;

        public OptionMemberInformation(int id)
        {
            _id = id;
        }

        public int MyId { get => _id; set => _id = value; }

        public Member findMember(School school, string firstName, string lastName)
        {
            List<Member> myMembers = school.Member;
            List<Member> myStudents = school.Student;
            foreach (Member member in myMembers)
            {
                if(member.Name.Equals(firstName) && member.LastName.Equals(lastName))
                {
                    return member;
                }
            }
            foreach (Member member in myStudents)
            {
                if (member.Name.Equals(firstName) && member.LastName.Equals(lastName))
                {
                    return member;
                }
            }
            Member noMember = new("noMember", "noMember", "noMember", "noMember");
            return noMember;
        }

        public int Execute(School school)
        {

            Console.WriteLine("Member information: ");
            Console.WriteLine("Member name: ");
            string memberName = Console.ReadLine();
            Console.WriteLine("Member lastname: ");
            string memberLastName = Console.ReadLine();
            
            Member requestedMember = findMember(school, memberName, memberLastName);
            
            if (requestedMember.Name.Equals("noMember"))
            {
                Console.WriteLine("No such member in database.");

                Console.WriteLine("------------");

                IOption optionPrintMenu1 = new OptionPrintMenu(0);

                Printer printer1 = new Printer();

                printer1.ListOfOptions.Add(optionPrintMenu1);
                printer1.printCommand(0, school);
            }


            Console.WriteLine("------------");
            requestedMember.PrintMyInfo();
            Console.WriteLine("------------");


            IOption optionPrintMenu = new OptionPrintMenu(0);

            Printer printer = new Printer();

            printer.ListOfOptions.Add(optionPrintMenu);
            printer.printCommand(0, school);


            return 0;
        }
    }
}
