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

            Console.WriteLine("You must choose to go left or right");
            answer = Console.ReadLine();

            if (answer.ToLower() == "left")
            {
                Console.WriteLine("You immediatley get punched by a ghost");
                Console.WriteLine("You get up and must decide if you are going to swing on the vines or continue walking. (vines/continue)");
                answer = Console.ReadLine();
                if(answer.ToLower() == "vines")
                {
                    Console.WriteLine("You turn into a monkey");
                }
                else if (answer == "continue")
                {
                    Console.WriteLine("You get thirsty and find a pond");
                }
            }
            else if (answer.ToLower() == "right")
            {
                Console.WriteLine("You immediatley meet a green monster");
                Console.WriteLine("You must decide if you are going to run or attack. (run/attack)");
                answer = Console.ReadLine();
                if(answer.ToLower() == "run")
                {
                    Console.WriteLine("You escape the green monster and keep running");
                }
                else if ( answer == "attack")
                {
                    Console.WriteLine("The green monster begins to cry because he wanted to be friends");
                }
            }

        }   
    }
}
