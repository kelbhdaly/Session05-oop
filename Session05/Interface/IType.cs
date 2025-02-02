using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session05.Interface
{
    internal interface IType
    {

        // 1. Signature For Properties  // Can't Include Private
        public int MyProperty { get; set; }
        // 2. Signature For Methods => Can't Include Private
        public void MyMethod();
        //3. Implementations Default => Can Include Any Access Modifiers
        public void Func()
        {
            Console.WriteLine("I am Interface");
        }
    }
}
