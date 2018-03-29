using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDictionary
{
    class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Id { get; set; } // like the PK column

        public override string ToString()
        {
            return "ID: " + Id.ToString() + " First Name: " +FirstName + " Last Name: " + LastName;
        }

    }
}
