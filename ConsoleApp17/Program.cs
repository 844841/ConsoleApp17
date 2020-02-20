using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sampleclasslibrary;

namespace sampleclasslibrary

{
    class Program
    {
        static void Main(string[] args)
        {
            recarea a = new recarea();
            a. length = 404;
            a.breadth = 50;
            Console.WriteLine(a.Area());

        }
    }
}
