using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal enum SecurityLevel
    {
        Guest, Developer, Secretary, DBA
    }
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Salary { get; set; }
        public string HireDate { get; set; }
        public char Gender { get; set; }
        public SecurityLevel Clearance { get; set; }

        public override string ToString()
        {
            return $"Employee ID: {Id}, Name: {Name}, Salary: {Salary}, Hiredate: {HireDate}, Gender: {Gender}";
        }
    }
}
