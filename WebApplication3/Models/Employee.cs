﻿namespace WebApplication3.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Department { get; set; }

        public Employee(int EmployeeId, string FirstName, string LastName, string Email, string Department)
        {
            this.EmployeeId = EmployeeId;
            this.FirstName = FirstName;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Email = Email;
            this.Department = Department;
        }

    }
}
