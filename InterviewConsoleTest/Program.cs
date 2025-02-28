using InterviewConsoleTest;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        Console.WriteLine("Starting application...");

        //Implement three classes, all must implement ILogger interface:
        //1. a FileLogger, which logs a message to a file
        //2. a ConsoleLogger, which logs a message to the consoler
        //3. a CompositeLogger, which accepts a number of ILogger and uses all of them

        //Instantiate a CompositeLogger, which will use a FileLogger and a CompositeLogger

        //LogResult for CompositeLogger is Successful if ALL loggers are successful. ErrorMessage is the concatenation of each ErrorMessage of each logger (if any)

        Console.WriteLine("Application finished.");
    }
}
