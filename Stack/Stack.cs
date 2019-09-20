using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    
        public class Stack<T> : AbstractExample
    {
            private T[] stackaray;
            private int maxlength;
            public int Size { get; set; }
            public Stack(int len)
            {
                maxlength = len;
                stackaray = new T[len];
            }
        public void Push(T value)
        {
            if (Size == maxlength)
                throw new ExceedSizeException();
            stackaray[Size++] = value;

        }
        public T Pop()
        {
            if (Size == 0)
                throw new ProhibitedException();
            return stackaray[--Size];
        }

        }
    
}
