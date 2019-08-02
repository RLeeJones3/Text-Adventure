using System;

namespace Text_Adventure
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to The Forest");
            Console.WriteLine("Are you ready for an adventure? (yes/no)");

            string answer = Console.ReadLine();

            if(answer.ToLower() == "yes")
            {
                Console.WriteLine("Sweet! Let's go!");
            }
            else if (answer == "no")
            {
                Console.WriteLine("Well too bad. Better get ready anyway");
            }
        }   
                

    }
}
