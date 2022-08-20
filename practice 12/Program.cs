using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nullStr = null;
            Console.WriteLine(String.IsNullOrEmpty(nullStr));

            string emptyStr2 = String.Empty;
            Console.WriteLine(String.IsNullOrEmpty(emptyStr2));
            Console.ReadLine();
        }
    }
}
