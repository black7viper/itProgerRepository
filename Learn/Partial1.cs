using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn
{
    public partial class PartialClass
    {
        public void Move()
        {
            Console.WriteLine("I am moving");
        }
        partial void Read();
        public void DoSomething()
        {
            Read();
        }

    }
}
