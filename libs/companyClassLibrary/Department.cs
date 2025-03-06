using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyClassLibrary
{
    public struct Department
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String Email { get; set; }
        public int Password { get; set; }

        public Department()
        {
            Random random = new Random();
            Password = random.Next(1, 1000);
        }

        public Department(string name, string email)
            : this()
        {
            Name = name;
            Email = email;
        }

        public Department(int id, string name, string email)
            : this(name, email)
        {
            Id = id;
        }
    }
}
