using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSTest
{
    class Log
    {
        [Conditional("DEBUG")]
        public void DebugLog(string str)
        {
            Console.Write("[DBG]" + str);
        }

        public void ErrorLog(string str)
        {
            Console.Write("[ERR]" + str);
        }
    }
}
