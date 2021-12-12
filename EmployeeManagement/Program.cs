using EmployeeManagement;
using System;

namespace EmployeeManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to EmployeePayRoll");
            EmployeeRepo repo = new EmployeeRepo();
            EmployeeModel employee = new EmployeeModel();

            employee.EmployeeName = "Varun13016";
            employee.PhoneNumber = "87754465546";
            employee.Address = "Banglore";
            employee.Department = "PROD.Manager";
            employee.Gender = 'M';
            employee.BasicPay = 800563;
            employee.Deductions = 212;
            employee.TaxablePay = 454;
            employee.Tax = 465;
            employee.NetPay = 25898;
            employee.City = "Banglore";
            employee.Country = "India";
            employee.StartDate = DateTime.Now;

            repo.AddEmployee(employee);
            repo.GetAllEmployee();

            Console.WriteLine("Retrived Data SuccessFully");

            
        }
    }
}