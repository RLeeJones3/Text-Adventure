using System;

namespace Text_Adventure
{
    class Program
    {
        static string AskQuestion(string question)
        {
            Console.WriteLine(question);
            string answer = Console.ReadLine();
            return answer;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to The Forest");
            string answer = AskQuestion("Are you ready for an adventure? (yes/no)");

            if(answer.ToLower() == "yes")
            {
                Console.WriteLine("Sweet! Let's go!");
            }
            else if (answer == "no")
            {
                Console.WriteLine("Well too bad. Better get ready anyway");
            }

           
            answer = AskQuestion("You must choose to go left or right");

            if (answer.ToLower() == "left")
            {
                Console.WriteLine("You immediatley get punched by a ghost");
                answer = AskQuestion("You get up and must decide if you are going to swing on the vines or continue walking. (vines/continue)");
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
              
                answer = AskQuestion(("You must decide if you are going to run or attack. (run/attack)"));
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
