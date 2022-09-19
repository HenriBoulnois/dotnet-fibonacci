// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using Leonardo;

class Program {
    static void Main(string[] args)
    {
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        var resList = Fib.RunAsync(args);
        stopwatch.Stop();
        TimeSpan stopwatchElapsed = stopwatch.Elapsed;
        foreach (var result in resList)
        {
            Console.WriteLine("Finished {0:N0}", result);
        }
    
        Console.WriteLine("Time duration : " + Convert.ToInt32(stopwatchElapsed.TotalMilliseconds) + " ms");
        
    }
}
