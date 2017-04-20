using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;

namespace ProcessPool
{
    class Program
    {
        static void Main(string[] args)
        {
            string commandsFile = ConfigurationManager.AppSettings["commandsFile"];
            string processMaxNumber = ConfigurationManager.AppSettings["processMaxNumber"];
            int maxNumber = Convert.ToInt32(processMaxNumber);
            // Read txt file from commands.txt
            // foreach every command, and start process with maxNumber number processes according to the command,
            // then waiting the exist process exit and start new process to maxNumber number processes until all commands in commands are done.
            // then show the final result: "All Pass", "Partial Pass, command "***" need to retry", "All Failed".
            // if show the text with Green, Yellow, Red color on the console, it will be better.
            Console.WriteLine("Please press Enter key to exit the program.");
            Console.ReadKey();
        }
    }
}
