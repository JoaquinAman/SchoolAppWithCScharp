using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkManagerCourse
{
    internal struct Member
    {
        private string _name;
        private string _lastName;
        private string _email;
        private string _rol;
        private Guid _id;

        public string Name
        {
            get { return _name; }
        }
        public string LastName
        {
            get { return _lastName; }
        }
        public Member(string name, string lastName, string email, string rol)
        {
            _name = name;
            _lastName = lastName;
            _email = email;
            _rol = rol;
            _id = Guid.NewGuid();
        }
        public void PrintMyInfo()
        {
                Console.WriteLine("Name = " + _name + " " + _lastName);
                Console.WriteLine("Email = " + _email);
                Console.WriteLine("Rol = " + _rol);
                Console.WriteLine("ID = " + _id);   
        }

        public Guid generateID()
        {
            return Guid.NewGuid();
        }
    }
}
