using System.Collections.Generic;
using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many employee will be registred? ");
            int n = int.Parse(Console.ReadLine());
            List<Employee> list = new List<Employee>();

            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Employee #" + i +":");
                Console.WriteLine("Id: ");
                int id = int.Parse(Console.ReadLine());

                Console.WriteLine("Name: ");
                string name = Console.ReadLine();

                Console.WriteLine("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                list.Add(new Employee(id, name, salary));
                Console.WriteLine();
            }

            Console.WriteLine("Enter the employee id that will have salary increase: ");
            int searchId = int.Parse(Console.ReadLine());

            Employee emp = list.Find(x => x.Id == searchId);

            if(emp != null)
            {
                Console.WriteLine("Enter the percentage: ");
                double percentege = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.IncreaseSalary(percentege);
            }
            else
            {
                Console.WriteLine("This id does not exists! ");
            }

            Console.WriteLine();
            Console.WriteLine("Update list of employees: ");

            foreach(Employee obj in list)
            {
                Console.WriteLine(obj);
            }
            
        }
    }
}
