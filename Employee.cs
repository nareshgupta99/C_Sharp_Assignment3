using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    public class Employee
    {
      private  int age;
      private string name;
      private float salary;

        public Employee(int age,string name,float salary)
        {
            this.age = age;
            this.name = name;   
            this.salary = salary;
        }

        override
        public String ToString()
        {
            return ""+this.age+" "+this.name+" "+this.salary;
        }

        public String DisplayEmployee()
        {
            return this.ToString();
        }
    }
}
