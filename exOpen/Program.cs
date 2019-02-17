using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace exOpen
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string path = args[0];
                Process.Start(path);
            } catch {
            }
        }
    }
}
