using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyNamespace
{
    internal class Property
    {
        private int age;
     
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
    }
}
