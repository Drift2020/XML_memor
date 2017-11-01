using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoreNET
{
    class ConsoleLog : ILog
    {
        public void Print(string s)
        {
            Console.WriteLine(s);
           
        }
    }
}
