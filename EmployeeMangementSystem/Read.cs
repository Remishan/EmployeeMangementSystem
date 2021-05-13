using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeMangementSystem
{
    class Read
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public double Salary { get; set; }
        public string Email { get; set; }
        public Read()
        {
            Name = "No Record";
            Age = 0;
            Salary = 0;
            Email = "No  Record";
        }
    }
}
