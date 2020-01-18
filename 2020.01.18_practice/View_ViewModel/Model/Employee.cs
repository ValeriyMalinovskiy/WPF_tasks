using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using View_ViewModel.Model;

namespace View_ViewModel
{
    public class Employee
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public Department EmployeeDepartment { get; set; }

        public DateTime HiredDate { get; set; }

        public bool IsManager { get; set; }

        public Employee(string firstName, string lastName, Department employeeDepartment, DateTime hiredDate, bool isManeger)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.EmployeeDepartment = employeeDepartment;
            this.HiredDate = hiredDate;
            this.IsManager = IsManager;
        }

        public override string ToString()
        {
            return $"{this.FirstName}" + " "+ $"{this.LastName}";
        }
    }
}
