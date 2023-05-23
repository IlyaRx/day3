using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day3
{
    class Employee
    {
        public Employee(string lastNamek, string firstNamek, string surnamek, int departmentk, int salaryk)
        {
            idAuto++;
            id = idAuto;
            lastName = lastNamek;
            firstName = firstNamek;
            surname = surnamek;
            department = departmentk;
            salary = salaryk;
        }

        private static int idAuto = 0; // счётчик
        private int id; // ИД сотрудника 
        private string lastName; // фамилия
        private string firstName; // Имя
        private string surname; // отчество
        private int department; // отдел от 1 до 5
        private int salary; // зарплата
        
        public int ID
        {
            get{ return id; }
        }
        public string LastName // фамилия
        {
            get{ return lastName; }
            set{ lastName = value; }
        }
        public string FirstName // Имя
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string Surname // отчество
        {
            get{ return surname; }
            set{ surname = value; }
        }
        public int Department // отдел от 1 до 5
        {
            get{ return department; }
            set{ department = value; }
        }
        public int Salary // зарплата
        {
            get{ return salary; }
            set{ salary = value; }
        }

    }
}
