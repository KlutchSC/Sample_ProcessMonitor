using System;
using System.Diagnostics;

namespace Sample_ProcessMonitor
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                if (Console.Read() == 's') { ShowProcesses();}


                if (Console.Read() == 'q')
                    break;
            }
        }

        private static void ShowProcesses()
        {
            Process[] localAll = Process.GetProcesses();
            foreach (var proc in localAll)
            {
                Console.WriteLine(proc.ProcessName);
            }
        }
    }
}
