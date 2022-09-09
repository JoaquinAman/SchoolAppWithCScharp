using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkManagerCourse.printer
{
    internal class Printer : IPrinter
    {
        private List<IOption> _listOfOptions = new List<IOption>();

        public List<IOption> ListOfOptions { get { return _listOfOptions; } }
        public void execute(IOption option, School school)
        {
            option.Execute(school);
        }

        public void printCommand(int option, School school)
        {
            foreach( IOption optionInList in _listOfOptions)
            {
                if(optionInList.MyId == option)
                {
                    execute(optionInList, school);
                }
            }
        }
    }
}
