using System.Diagnostics;

namespace exOpen
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string path = string.Join(" ", args, 0, args.Length);
                Process.Start(path);
            } catch { }
        }
    }
}
