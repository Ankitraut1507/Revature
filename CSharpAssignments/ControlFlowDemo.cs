using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssignments
{
    internal class ControlFlowDemo
    {
        public static void Run()
        {
            int number = 10;

            if (number > 0)
                Console.WriteLine("Positive number");
            else
                Console.WriteLine("Negative number");
        }
    }
}
