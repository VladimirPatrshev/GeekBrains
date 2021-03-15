using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SApp01
{
    
    public partial class MyClass
    {
        public int A { get; set; }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            var myClass = new MyClass();
            myClass.A = 1;
            myClass.B = 2;
        }
    }
}
