using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp
{
    partial class Employee
    {
        //Поля данных
        private string empName;
        private int empID;
        private float currPay;
        private int empAge;
        private string empSSN;
        //Конструкторы
        public Employee() { }
        public Employee(string name, int age, int id, float pay, string ssn)
        {
            Name = name;
            Age = age;
            ID = id;
            Pay = pay;
            empSSN = ssn;
        }
    }
}