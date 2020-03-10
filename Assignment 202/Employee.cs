using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_202
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int empID { get; set; }

        public Employee(int id, string fn, string ln)
        {
            empID = id;
            FirstName = fn;
            LastName = ln;
        }
    }
}
