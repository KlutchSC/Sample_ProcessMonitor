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

                if (Console.ReadLine() == "help")
                {
                    ShowCommands();
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
            try
            {
                var process = Process.GetProcessById(procId);
                Console.WriteLine("Name: {0}\nId: {1}", process.ProcessName, process.Id);
            }
            catch (Exception)
            {
                Console.WriteLine("No process found with provided Id");
            }
        }

        private static void ShowCommands()
        {
            Console.WriteLine("'show' => shows all processes running on the local machine" );
            Console.WriteLine("'name' => shows all processes running with the provided name");
            Console.WriteLine("'id' => shows the process with a provided process id");
        }
    }
}
