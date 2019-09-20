using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    public delegate bool IsEligibleForPramotion(Employee Emp);
    public class Employee
    {
        private int EmpId;
        public int EMPID
        {
            get
            {

             return EmpId   ;
            }
            set{
                this.EmpId=value;
        }
        }

        private string Name;
        public string NAME
        {
            get{return Name;
        }
            set {this.Name=value; }
        }
        private char Gender;
        public char GENDER
        {
            get { return Gender; }
            set { this.Gender = value; }
        }
        private string address;
        public string ADDRESS
        {
            get {return address; }
            set { this.address = value; }
        }
        private int Salary;
        public int SALARY
        {
            get { return Salary; }
            set { this.Salary = value; }
        }

        private int Experience;
        public int EXPERIENCE
        {
            get {return Experience; }
            set { this.Experience = value; }
        }
        public static List<Employee> PramoteEmployee(List<Employee> lstEmployee, IsEligibleForPramotion IsEligible)
        {
            List<Employee> EligibleEmployee = new List<Employee>();
            foreach(Employee  emp in lstEmployee)
            {
                if(IsEligible(emp))
                {
                    EligibleEmployee.Add(emp);
                }
            }
            return EligibleEmployee;
        }
        public void Display()
        {
            Console.WriteLine("Employee ID" + this.EmpId);
            Console.ReadKey();
        }
    }
}
