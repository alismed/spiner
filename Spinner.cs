using System;

namespace spinner
{
    public class Spinner
    {
        int counter;
        static string[,] options = null;
        int totalOptions = 0;
        int sequence;

        public Spinner()
        {
            counter = 0;

            options = new string[,] {
                { "/", "-", "\\", "|", "-" },
                { ".", "o", "O", "0", "o" },
                { "+", "-", "X", "-", "+" },
                { "v", "<", "^", ">", "X" },
                { " ", "░", "▒", "▓", "█" },
                { "└", "┘", "┐", "┌", "-"},
                { "▄", "■", "▀", "■", " "}
            };

            totalOptions = options.GetLength(0);

            Random rnd = new Random();
            sequence = rnd.Next(totalOptions);
        }

        public void Turn()
        {
            counter++;
            System.Threading.Thread.Sleep(200);

            switch (counter % 5)
            {
                case 0: Console.Write(options[sequence, 0]); break;
                case 1: Console.Write(options[sequence, 1]); break;
                case 2: Console.Write(options[sequence, 2]); break;
                case 3: Console.Write(options[sequence, 3]); break;
                case 4: Console.Write(options[sequence, 4]); break;
            }
            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
        }
    }
}