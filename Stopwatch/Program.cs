using System.Diagnostics;
using System.Net;
using System.Runtime.InteropServices;

class Program{
    static void Main(string[] args){
        StopWatch stopwatch = new StopWatch();
        stopwatch.OnStarted += message => Console.WriteLine(message);
        stopwatch.OnTimeUpdated += time =>
        {
            Console.Clear();
            Console.WriteLine("\nPress S to start, T to stop, R to reset, Q to quit");
            Console.WriteLine($"\rElapsed Time: {time:hh\\:mm\\:ss}");
        };

        stopwatch.OnReset += message => Console.WriteLine(message); 
        stopwatch.OnStopped += message => Console.WriteLine(message);

        while(true){
            Console.WriteLine("\nPress S to start, T to stop, R to reset, Q to quit");
            string? input = Console.ReadLine()?.ToUpper();

            switch(input){
                case "S":
                    stopwatch.Start();
                    break;
                case "T":
                    stopwatch.Stop();
                    break;
                case "R":
                    stopwatch.Reset();
                    break;
                case "Q":
                    return;
                default:
                    Console.WriteLine("Invalid Input");
                    break;
            }
        }
    }
}