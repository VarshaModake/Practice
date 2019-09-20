using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    
    public class program
    {

        public static int Add(params object[] Array)
        {
            int total = 0;
            for(int i= 0; i< Array.Length;i++)
            {
                Console.WriteLine(Array[i]);
            }
            return total;
        }
        public static void Main(string[] args)
        {
            Employee emp1 = new Employee()
            {
                EMPID = 101,
                NAME="Varsha",
                ADDRESS="ABC",
                EXPERIENCE=7,
                GENDER='F',
                SALARY=500000
            };

            Employee emp2 = new Employee()
            {
                EMPID = 102,
                NAME = "Pravin",
                ADDRESS = "XYZ",
                EXPERIENCE = 10,
                GENDER = 'M',
                SALARY = 600000
            };

            Employee emp3 = new Employee()
            {
                EMPID = 103,
                NAME = "Megha",
                ADDRESS = "hfjhdfk",
                EXPERIENCE = 15,
                GENDER = 'F',
                SALARY = 800000
            };

            Employee emp4 = new Employee()
            {
                EMPID = 104,
                NAME = "Akash",
                ADDRESS = "dkhdh",
                EXPERIENCE = 3,
                GENDER = 'M',
                SALARY = 200000
            };

            Employee emp5 = new Employee()
            {
                EMPID = 104,
                NAME = "Nikita",
                ADDRESS = "whdw",
                EXPERIENCE = 1,
                GENDER = 'F',
                SALARY = 100000
            };
            List<Employee> lstEMployee = new List<Employee>();
            lstEMployee.Add(emp1);
            lstEMployee.Add(emp2);
            lstEMployee.Add(emp3);
            lstEMployee.Add(emp4);
            lstEMployee.Add(emp5);
         

            string method;
            do
            {
                Console.WriteLine("\nPlease select Pramotion Method:");
                Console.WriteLine("1.By Experience");
                Console.WriteLine("2.By Salary(Less salary eligible for pramotion");
                Console.WriteLine("0.For Exit");


                method = Console.ReadLine();
                List<Employee> lstemp = new List<Employee>();
                switch (method)
                {
                    case "1":
                       lstemp = Employee.PramoteEmployee(lstEMployee, x=>x.EXPERIENCE > 5);
                        break;
                    case "2":
                       lstemp = Employee.PramoteEmployee(lstEMployee, x=>x.SALARY > 500000);
                        break;


                }

                foreach (Employee emp in lstemp)
                {
                    Console.WriteLine(emp.NAME + " is pramoted");
                }
            } while (!method.Equals("0"));


            DelegateExample objDel = new DelegateExample();
            ResultDelegate rs = new ResultDelegate(objDel.add);
            rs(10, 20);
            rs = objDel.sub;
            rs(20, 10);
            rs = objDel.Mul;
            rs.Invoke(2, 5);

            //ResultDelegate rsm = new ResultDelegate(objDel.add);
            //rsm += objDel.sub;
            //rsm += objDel.Mul;

            //rsm(4, 2);

            //rsm -= objDel.sub;
            //rsm(5, 2);

            //Console.ReadKey();
            //int sum = Add(3, 5, "Varsha", 8, 1);

            //Stack<int> st = new Stack<int>(3);
            //st.display();
            //Car c=new Car();
            //c.Color = "RED";
            //Console.WriteLine($"Color of the car is {c.GetDiscription()}");

            //Car b = new Car()
            //{
            //    Color = "Green"
            //};
            //Console.WriteLine($"Color of the car is {b.GetDiscription()}");


            //Car d = new Car("Blue");
            //Console.WriteLine($"Color of the car is {d.GetDiscription()}");
            //var names=new List<string> { "varsha","megha","pravin"}
            //     Console.ReadKey();
        }
    }
}
