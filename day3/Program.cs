using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day3
{
    class Program
    {
        static void average(List<Employee> employees)
        {
            Console.WriteLine($"{SumSalary(employees)/employees.Count}");
        }
        static void sort(List<Employee> employees)
        {
            Employee MinSalary;
            for (int i = 0; i < employees.Count; i++)
            {
                for (int j = i + 1; j < employees.Count; j++)
                {
                    if (employees[i].ID > employees[j].ID)
                    {
                        MinSalary = employees[i];
                        employees[i] = employees[j];
                        employees[j] = MinSalary;
                    }
                }
            }
        }
        static void ListPeople(List<Employee> employees)
        {
            foreach(var e in employees)
            {
                Console.WriteLine($"\n\nid = {e.ID}" +
                    $"\n{e.LastName}" +
                    $"\n{e.FirstName}" +
                    $"\n{e.Surname}" +
                    $"\n{e.Department}" +
                    $"\n{e.Salary}");
            }
        }

        static int SumSalary(List<Employee> employees)
        {
            int sum = 0;
            foreach(var e in employees)
            {
                sum += e.Salary;
            }
            Console.WriteLine($"Сумма затрат на зарплату = {sum}");
            return sum;
        }

        static void MinSalary(List<Employee> employees)
        {
            Employee MinSalary;
            for (int i = 0; i < employees.Count; i++)
            {
                for (int j = i + 1; j < employees.Count; j++)
                {
                    if (employees[i].Salary > employees[j].Salary)
                    {
                        MinSalary = employees[i];
                        employees[i] = employees[j];
                        employees[j] = MinSalary;
                    }
                }
            }
            Console.WriteLine($"\n\nid = {employees[0].ID}" +
                $"\n{employees[0].LastName}" +
                $"\n{employees[0].FirstName}" +
                $"\n{employees[0].Surname}" +
                $"\n{employees[0].Department}" +
                $"\n{employees[0].Salary}");
            sort(employees);
        }

        static void MaxSalary(List<Employee> employees)
        {
            Employee MaxSalary;
            for (int i = 0; i < employees.Count; i++)
            {
                for (int j = i + 1; j < employees.Count; j++)
                {
                    if (employees[i].Salary > employees[j].Salary)
                    {
                        MaxSalary = employees[i];
                        employees[i] = employees[j];
                        employees[j] = MaxSalary;
                    }
                }
            }
            Console.WriteLine($"\n\nid = {employees[employees.Count-1].ID}" +
                              $"\n{employees[employees.Count - 1].LastName}" +
                              $"\n{employees[employees.Count - 1].FirstName}" +
                              $"\n{employees[employees.Count - 1].Surname}" +
                              $"\n{employees[employees.Count - 1].Department}" +
                              $"\n{employees[employees.Count - 1].Salary}");
            sort(employees);
        }
        static void FIO(List<Employee> employees)
        {
            foreach (var e in employees)
            {
                Console.WriteLine($"\n{e.LastName}" +
                    $"\n{e.FirstName}" +
                    $"\n{e.Surname}");
            }
        }
        static void Main(string[] args)
        {
            List<Employee> people = new List<Employee>()
            {
            new Employee("Фамилия1", "Имя", "отчество", 1,10001),
            new Employee("Фамилия2", "Имя", "отчество", 3,100023),
            new Employee("Фамилия3", "Имя", "отчество", 2,1035400),
            new Employee("Фамилия4", "Имя", "отчество", 3,13000),
            new Employee("Фамилия5", "Имя", "отчество", 1,1000),
            };

            bool prov = true;
            while (prov)
            {
                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        ListPeople(people);
                        Console.WriteLine("//////////////////////////////////////////////////////////");
                        break;

                    case 2:
                        SumSalary(people);
                        Console.WriteLine("//////////////////////////////////////////////////////////");
                        break;

                    case 3:
                        MinSalary(people);
                        Console.WriteLine("//////////////////////////////////////////////////////////");
                        break;

                    case 4:
                        MaxSalary(people);
                        Console.WriteLine("//////////////////////////////////////////////////////////");
                        break;
                    case 5:
                        average(people);
                        Console.WriteLine("//////////////////////////////////////////////////////////");
                        break;
                    case 6:
                        FIO(people);
                        Console.WriteLine("//////////////////////////////////////////////////////////");
                        break;
                    case 7:
                        prov = false;
                        break;

                }
            }
            Console.ReadKey();

        }
    }
}
