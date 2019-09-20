using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    struct Car 
    {
        private string color;
        public string Color
        {
            get
            {
                return color;
            }
            set
            {
                color = value;
            }

        }
        public Car(string str)
        {
            this.color = str;
        }

        public String GetDiscription()
        {
            return this.color;
        }
    }
}
