using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elephant
{
    class Elephant
    {
        public int EarSize;
        public string Name;

        public void WhoAmI(string name, int earSize)
        {
            Console.WriteLine("Calling " + name + ".WhoAmI()");
            Console.WriteLine("My name is " + name + ".");
            Console.WriteLine("My ears are " + earSize + " inches tall.");
        }
    }
}
