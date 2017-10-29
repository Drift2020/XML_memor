using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MemoreNET
{
    class FileLog : ILog
    {
        public void Print(string s)
        {
            StreamWriter sw = new StreamWriter("File.log", true);
            s=s.Replace("\n", "\r\n");
            sw.WriteLine(s);
            sw.Close();
        }
    }
}
