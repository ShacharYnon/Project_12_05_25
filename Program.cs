using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_12_05_25
{
    internal class Program
    {
        static void CallArgs(string[] args)
        {/*
          * A func that receives arguments from the debuggr(defalt)
          */
            foreach (var arg in args)
            {
                Console.WriteLine(arg);
            }
        }
        
        static void Main(string[] args)
        {
            CallArgs(args);
        }
    }
}
