using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkManagerCourse.printer
{
    internal class OptionCloseApp : IOption
    {
        private int _id;

        public OptionCloseApp(int id)
        {
            _id = id;
        }

        public int MyId { get => _id; set => _id = value; }

        public int Execute(School school)
        {
            System.Environment.Exit(0);

            return 0;
        }
    }
}
