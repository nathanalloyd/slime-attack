using System;
using static System.Console;

namespace slime_attack
{
    class Program
    {
        static void Main(string[] args)
        {
            int desiredWidth = 110;
            int desiredHeight = 58;
            try
            {
                WindowHeight = desiredHeight;
                WindowWidth = desiredWidth;
            }
            catch (System.ArgumentOutOfRangeException error)
            {
                ForegroundColor = ConsoleColor.Red;
                WriteLine("");
                WriteLine("\t -- Warning -- ");
                WriteLine("\t Your screen isn't big enough to match the game's desired width & height.");
                WriteLine("\t Things may not look right unless you manually adjust the size of your console window.");
                WriteLine("\t Press any key to continue.");
                ReadKey(true);
                ForegroundColor = ConsoleColor.Green;
                Clear();
            }

            Game myGame = new Game();
            myGame.Start();
        }
    }
}
