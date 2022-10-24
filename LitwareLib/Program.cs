using System;

namespace LitwareLib
{
    internal class Program
    {
        static void Main(string[] arga)
        {
            Library library = new Library();
            int ch;
            int des;
            do
            {
                Console.WriteLine("1. Register the employees in company");
                Console.WriteLine("2. Display employee");
                Console.WriteLine("3. Exit\n");
                Console.Write("Your choice: ");
                ch = int.Parse(Console.ReadLine());
                try
                {
                    if (ch == 1)
                    {
                        Console.Write("  Enter Employee Details :- \n  ");
                        Console.Write("\n  Enter Employee ID: ");
                        int ID = Convert.ToInt32(Console.ReadLine());
                        Console.Write("  Enter Employee Name: ");
                        string Name = Console.ReadLine();
                        Console.Write("  Enter Employee Salary: ");
                        double Salary = double.Parse(Console.ReadLine());
                        Console.WriteLine(" Select Designation : ");
                        Console.WriteLine(" 1 Employee  ");
                        Console.WriteLine(" 2 Manager  ");
                        Console.WriteLine(" 3 Marketing Executive  ");
                        des = int.Parse(Console.ReadLine());
                        // string Designation = Console.ReadLine();


                        Console.WriteLine();
                        if (des == 1)
                        {
                            string temp = "Employee";
                            Employee emp = new Employee();
                            emp.SetEmployee(ID, Name, Salary, temp);
                            library.AddEmployee(emp);
                        }
                        else if (des == 2)
                        {
                            string temp = "Manager";
                            Employee emp = new Employee();
                            emp.SetEmployee(ID, Name, Salary, temp);
                            library.AddEmployee(emp);
                        }
                        else if (des == 3)
                        {
                            string temp = "Marketing Executive";
                            Employee emp = new Employee();
                            emp.SetEmployee(ID, Name, Salary, temp);
                            library.AddEmployee(emp);
                        }


                    }
                    else if (ch == 2)
                    {
                        library.DisplayEmployees();

                    }
                    else if (ch == 3) { } else { Console.WriteLine("Invalid Input !!!"); }
                }
                catch (Exception error)
                {
                    Console.WriteLine("\n ERR !!! : " + error.Message + "\n");
                }


            } while (ch != 3);
            Console.ReadKey();
        }
    }
}
