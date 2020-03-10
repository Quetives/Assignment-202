using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_202
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>() { };

            Employee emp1 = new Employee(1, "Richard", "Quetives");
            employees.Add(emp1);
            Employee emp2 = new Employee(2, "Dick", "Q");
            employees.Add(emp2);
            Employee emp3 = new Employee(3, "Anahiza", "Carrillo");
            employees.Add(emp3);
            Employee emp4 = new Employee(4, "Joe", "Smith");
            employees.Add(emp4);
            Employee emp5 = new Employee(5, "Joe", "Sanders");
            employees.Add(emp5);
            Employee emp6 = new Employee(6, "Jim", "Butler");
            employees.Add(emp6);
            Employee emp7 = new Employee(7, "Holly", "Westen");
            employees.Add(emp7);
            Employee emp8 = new Employee(8, "Steven", "Piper");
            employees.Add(emp8);
            Employee emp9 = new Employee(9, "Carol", "Doolie");
            employees.Add(emp9);
            Employee emp10 = new Employee(10, "Lucas", "Harrington");
            employees.Add(emp10);

            List<Employee> joes = employees.Where(x => x.FirstName == "Joe").ToList();
            foreach(Employee employee in joes)
            {
                Console.WriteLine(employee.FirstName + " " + employee.LastName );
            }
            Console.ReadLine();
           // List<string> joes = new List<string>();
           // foreach (Employee employee in employees)
           // {
           //     if (employee.FirstName == "Joe")
           //     {
           //         joes.Add(employee.FirstName + " " + employee.LastName); 
           //     }
           // }
           //foreach(var i in joes)
           // {
           //     Console.WriteLine(i);
           // }

           // int count = employees.FirstName.Count(x => x.FirstName == FirstName.Joe);

            List<Employee> g5 = employees.Where(x => x.empID > 5).ToList();
            foreach (Employee employee in g5)
            {
                Console.WriteLine(employee.empID + " " + employee.FirstName + " " + employee.LastName);
            }

            Console.ReadLine();
        }
    }
    }

