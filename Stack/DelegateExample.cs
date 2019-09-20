using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    public delegate void ResultDelegate(int a, int b);
    class DelegateExample
    {
        

        public void add(int a,int b)
        {
            Console.WriteLine($"Sum of {a} ,{b} = {a + b}");
        }

        public void sub(int a,int b)
        {
            Console.WriteLine($"Sub of {a},{b}={a - b}");
        }

        public void Mul(int a,int b)
        {
            Console.WriteLine($"Mul of {a},{b}={a * b}");
        }
    }
}
