using System;
using System.Threading;

namespace spinner
{
    class Program
    {
        static Boolean running = false;
        private static Thread theSpiner;

        private static void Spiner()
        {
            ConsoleSpiner progress = new ConsoleSpiner();

            while (running)
                progress.Turn();
        }

        private static void startSpiner()
        {
            running = true;
            theSpiner = new Thread(Spiner);
            theSpiner.Name = "spiner";
            Console.WriteLine("Press CTRL-C to exit ");
            Console.WriteLine(String.Empty);
            Console.Write("Wait ");
            theSpiner.Start();
        }

        private static void stopSpiner()
        {
            running = false;
            Console.CursorTop = Console.CursorTop - 1;
        }

        static void Main(string[] args)
        {
            startSpiner();

            // do something
            Thread.Sleep(3000);

            // stop
            stopSpiner();
        }
    }
}
