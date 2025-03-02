using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal class Motorcyle : Vehicle
    {
        public bool HasSideCart { get; set; }
        public override void DriveAbstract()
        {
            Console.WriteLine("The Motorcyle is driving. .");
        }

       public override void DriveVirtual()
        {
            Console.WriteLine($"Motorcyle {Year} {Make} {Model} is driving.");
        }
    }
}
