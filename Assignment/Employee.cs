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
        private char _gender;
        public char Gender
        {
            get
            {
                return _gender;
            }
            set
            {
                char lowerGender = char.ToLower(value);
                if (lowerGender == 'm' || lowerGender == 'f')
                {
                    _gender = lowerGender;
                }
                else
                {
                    Console.WriteLine("Invalid Gender, Please choose either M(Male) or F(Female)");
                }
            }
        }
        public SecurityLevel Clearance { get; set; }

        public Employee(int _id, string _name, float _salary, string _hireDate, char _gender, SecurityLevel _clearance )
        {
            Id = _id;
            Name = _name;
            Salary = _salary;
            HireDate = _hireDate;
            Gender = _gender;
            Clearance = _clearance;
        }

        public override string ToString()
        {
            return $"Employee ID: {Id}, Name: {Name}, Salary: {Salary}, Hiredate: {HireDate}, Gender: {Gender}";
        }
    }
}
