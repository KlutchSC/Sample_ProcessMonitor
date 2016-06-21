using System;
using System.Diagnostics;

namespace Sample_ProcessMonitor
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                if (Console.ReadLine() == "show")
                {
                    ShowProcesses();
                }

                if (Console.ReadLine() == "name")
                {
                    Console.WriteLine("Enter the process name:");
                    ShowProcessByName(Console.ReadLine());
                }

                if (Console.ReadLine() == "id")
                {
                    Console.WriteLine("Enter the process id:");
                    ShowProcessById(Convert.ToInt32(Console.ReadLine()));
                }

                if (Console.ReadLine() == "quit")
                    break;
            }
        }

        private static void ShowProcesses()
        {
            var process = Process.GetProcesses();
            foreach (var proc in process)
            {
                Console.WriteLine("Name: {0}\nID: {1}\n ", proc.ProcessName, proc.Id);
            }
        }

        private static void ShowProcessByName(string procName)
        {
            var process = Process.GetProcessesByName(procName);
            foreach (var proc in process)
            {
                Console.WriteLine("Name: {0}\nID: {1}\n ", proc.ProcessName, proc.Id);
            }
        }

        private static void ShowProcessById(int procId)
        {
            var process = Process.GetProcessById(procId);
            Console.WriteLine("Name: {0}\nId: {1}", process.ProcessName, process.Id);
        }
    }
}
