﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Addon
{
    public class Loader
    {
        public string[][] GetFunctions() => new string[][] { new string[] { "test", "test" }, new string[] { "subclass.test2", "subclass_test2"} };
    }
    public class Functions
    {
        public string test(string cmd)
        {
            Console.WriteLine("sys lib running test-function; called by line: \"" + cmd + "\"");
            return "success!";
        }
        public string subclass_test2(string cmd)
        {
            return cmd + "/lol";
        }
    }
}