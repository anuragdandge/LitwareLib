using System;
using System.Collections.Generic;

namespace LitwareLib
{
    internal class Library
    {
        public readonly List<Employee> employees = new List<Employee>();

        public void AddEmployee(Employee emp)
        {
            this.employees.Add(emp);
        }

        public void DisplayEmployees()
        {
            Console.WriteLine("  Employee Details :- \n \n ");
            Console.WriteLine("----------------------------------------------------------------------------------- ");
           
            
            for (int i = 0; i < employees.Count; i++)
            {
                Console.WriteLine("[" + (i + 1) + "]\n");
                Console.WriteLine("  Employee ID: {0}", employees[i].number);
                Console.WriteLine("  Employee Name: {0}", employees[i].name);
                Console.WriteLine("  Employee Designation: {0}", employees[i].designation);
                Console.WriteLine("  Employee Salary: {0}", employees[i].salary);
                Console.WriteLine("  Employee HRA: {0}", employees[i].hra);
                Console.WriteLine("  Employee TA : {0}", employees[i].ta);
                Console.WriteLine("  Employee DA: {0}", employees[i].da);
                Console.WriteLine("  Employee PF: {0}", employees[i].pf);
                Console.WriteLine("  Employee TDS: {0}", employees[i].tds);
                Console.WriteLine("  Employee Gross Salary: {0}", employees[i].gross);
                Console.WriteLine("  Employee Net Salary: {0}", employees[i].net);
                Console.WriteLine();
            }
            Console.WriteLine("----------------------------------------------------------------------------------- ");

        }

    }


}
