using System;
using System.Diagnostics;
using System.IO;

namespace ServerMove
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Create menu to manage server move process
             * menu should include
             * - backup existing database
             * - activate full restore on current sql instance
             * - place transaction logs in destination folder
             * - restore logs onto future server instance (using NONRECOVERY and when time of move RECOVERY)
             * - log sucesses and failures
             * -
             */

            string scriptPath = "C:\\dev\\csharp\\ServerMove\\ServerMove\\test.ps1";

            Process process = new Process();
            process.StartInfo.FileName = "powershell.exe";
            process.StartInfo.Arguments = $"-File \"{scriptPath}\"";
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;

            process.Start();

            string output = process.StandardOutput.ReadToEnd();
            process.WaitForExit();

            Console.WriteLine(output);



        }
    }
}