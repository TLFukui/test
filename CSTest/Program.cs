﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSTest
{
    class Program
    {
        static void Main(string[] args)
        {
            StrClass strCs = new StrClass();
            string str;

            str = strCs.Hello() + " " + strCs.World();

            Console.WriteLine(str);
            strCs.DebugLog("デバッグログ出力\n");
        }
    }
}