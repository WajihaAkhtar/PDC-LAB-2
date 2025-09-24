using System;
using System.Runtime.CompilerServices;
using System.Threading;
class Program
{
    static void Main()
    {
        string m = ".......";
        int length = m.Length;
        for (int i = 0; i < length; i++)
        {
            Console.Write("\r" + new string(' ', i) + "C" + m.Substring(i + 1));
            Thread.Sleep(200);
            Console.Write("\r" + new string(' ', i + 1) + m.Substring(i + 1));
            Thread.Sleep(200);
        }
        Console.Write("\r" + new string(' ', length) + "C");
        Console.WriteLine("\n\nGame over! Pac-Man ate all the dots");
    }
}
