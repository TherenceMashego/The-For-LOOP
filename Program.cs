using System;

namespace The_For_LOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The while loop for reference:");

            int i = 0;
            while (i <= 5)
            {
                Console.Write(i + " "); // Add space for better separation
                i++;
            }

            Console.WriteLine(); // Move to the next line for clarity

            Console.WriteLine("The for loop:");

            for (i = 0; i < 5; i++)
            {
                Console.Write(i + " "); // Add space for better separation
            }

            Console.ReadLine(); // Pause to see the output
        }
    }
}
