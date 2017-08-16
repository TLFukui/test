using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSTest
{
    partial class StrClass
    {
        public string World()
        {
            string str = "World!";

            return str;
        }

        [Conditional("DEBUG")]
        public void DebugLog(string str)
        {
            Console.Write(str);
        }
    }
}
