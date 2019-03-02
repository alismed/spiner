using System;
using System.Threading;

namespace spinner
{
    class Program
    {
        static Boolean running = false;
        private static Thread theSpinner;

        private static void Spinner()
        {
            Spinner progress = new Spinner();

            while (running)
                progress.Turn();
        }

        private static void startSpinner()
        {
            running = true;
            theSpinner = new Thread(Spinner);
            theSpinner.Name = "spinner";
            Console.WriteLine("Press CTRL-C to exit ");
            Console.WriteLine(String.Empty);
            Console.Write("Wait ");
            theSpinner.Start();
        }

        private static void stopSpinner()
        {
            running = false;
            Console.CursorTop = Console.CursorTop - 1;
        }

        static void Main(string[] args)
        {
            startSpinner();

            // do something
            Thread.Sleep(3000);

            // stop
            stopSpinner();
        }
    }
}
