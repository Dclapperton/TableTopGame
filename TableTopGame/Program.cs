using System;

namespace TableTopGame
{
    public class Program
    {
        public static Location CurrentLocation { get; set; }

        public static void Main(string[] args)
        {
            CurrentLocation = new Location();

            Console.WriteLine("Please enter a command.");

            TableTop tableTop = new TableTop();
            tableTop.Start();
        }
    }
}
