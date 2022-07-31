using System;
namespace SnakeAndLadder
{
    class program
    {
        public static string CheckOption { get; private set; }

        public static void Main()
        {
            Console.WriteLine("CheckOption " + CheckOption);
            CheckOption.CheckOption();
        }
    }
}
