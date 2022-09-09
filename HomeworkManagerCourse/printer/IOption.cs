using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkManagerCourse.printer
{
    internal interface IOption
    {
        static int ID;
        
        public int MyId { get; set; }
        public int Execute(School school);
    }
}
