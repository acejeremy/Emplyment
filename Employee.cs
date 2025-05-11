using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDetail
{
    public class Employee
    {
       
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Department { get; set; }

       
        public Employee(string name, string surname, string gender, DateTime dateOfBirth, string department)
        {
            Name = name;
            Surname = surname;
            Gender = gender;
            DateOfBirth = dateOfBirth;
            Department = department;
        }

       
        public int AgeCalculator()
        {
            DateTime today = DateTime.Today;
            int age = today.Year - DateOfBirth.Year;

            if (today < DateOfBirth.AddYears(age))
                age--;

            return age;
        }
    }
}