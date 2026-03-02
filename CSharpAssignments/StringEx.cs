using System;
using System.Text;

namespace CSharpAssignments
{
    internal class StringEx
    {
        public static void Run()
        {

            string name = "Ankit";
            Console.WriteLine(name);

            name = name + " Raut";
            Console.WriteLine(name);

            Console.WriteLine();

            Console.WriteLine("STRINGBUILDER EXAMPLE");

            StringBuilder sb = new StringBuilder();
            sb.Append("Ankit");
            sb.Append(" ");
            sb.Append("Raut");

            Console.WriteLine(sb.ToString());
        }
    }
}
