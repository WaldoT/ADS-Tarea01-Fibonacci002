using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace BigONotationPartial
{
    class LogExample
    {
        static void Main(string[] args)
        {
            var stopWatch = new Stopwatch();
            stopWatch.Start();
            Console.WriteLine("Starting...");
            LogExample logExample = new LogExample();
            Console.WriteLine("Step 1: Reading Log Items...");
            var lineCount = logExample.ReadAllLogs();
            Console.WriteLine("{0:n0} Log Items Read", lineCount);
            Console.WriteLine("Step 2: Counting Unique IPs...");
            var ipCount = logExample.CountUniqueIPs();
            Console.WriteLine("Number of unique IPs: " + ipCount);
            Console.WriteLine("Time elapsed: {0:0.0} seconds", Math.Round(stopWatch.ElapsedMilliseconds / 1000.0, 2));
            Console.ReadLine();
        }

        int ReadAllLogs()
        {
            var logReader = new LogReader();
            var linesSeen = 0;
            foreach (var line in logReader)
            {
                var ip = line.GetIP();
                linesSeen++;
            }
            return linesSeen;
        }

        int CountUniqueIPs()
        {
            var logReader = new LogReader();
            //var ipsSeen = new List<string>();

            //HashSet : utiliza una tabla hash, por lo que las búsquedas son extremadamente rápidas.
            var ipsSeen = new HashSet<String>();
            foreach (var logLine in logReader)
            {
                var ip = logLine.GetIP();
                if (!ipsSeen.Contains(ip))
                {
                    ipsSeen.Add(ip);
                }
            }
            return ipsSeen.Count;
        }
    }
}
