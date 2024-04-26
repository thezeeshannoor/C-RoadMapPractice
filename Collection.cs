using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CollectionNamespace
{
    internal class Collection
    {
       public List<string> std = new List<string>() {"Zeeshan","Noor","Ali","umair"};

        public int Length { get; internal set; }
    }
}
