class Program
{
    static void Main(string[] args)
    {
        int maxValue = 100;
        int progressBarWidth = Console.WindowWidth - 16;
        int xStart = Console.CursorLeft;
        int yStart = Console.CursorTop;

        for (int i = 0; i <= maxValue; i++)
        {
            // calculate the current progress as a percentage of the maximum value
            int progress = (int)((double)i / maxValue * 100);

            // calculate the number of characters to write to the console
            int charactersToWrite = (int)((double)i / maxValue * progressBarWidth);

            int x = Console.CursorLeft;
            int y = Console.CursorTop;
            Console.CursorTop = Console.WindowTop + Console.WindowHeight - 1;

            // move the console cursor to the beginning of the progress bar
            Console.SetCursorPosition(0, Console.CursorTop);

            // write the progress bar to the console
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write("Progress: {0}%", string.Format("{0,3:###}", progress));
            Console.ResetColor();

            Console.Write("[");
            for (int j = 0; j < charactersToWrite; j++)
            {
                Console.Write("#");
            }
            for (int j = charactersToWrite; j < progressBarWidth; j++)
            {
                Console.Write("-");
            }
            Console.Write("]");

            // simulate some processing time
            System.Threading.Thread.Sleep(50);
        }

        // restore previous position
        Console.SetCursorPosition(xStart, yStart);

        Console.WriteLine();
        Console.WriteLine("Processing complete!");
    }
}
