using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkManagerCourse.printer
{
    internal interface IPrinter
    {
        public void printCommand(int option, School school);
        public void execute(IOption option, School school);
    }
}
