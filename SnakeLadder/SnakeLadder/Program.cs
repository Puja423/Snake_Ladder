using System;

namespace SnakeLadder
{
    class Program
    {
        static void Main(string[] args)
        {
            string snakeladder = null;
            int start = 0;
            int max = 100;
            int current_score = 0;
            int currentposition = start;
            Console.WriteLine(" welcome to the snakeladder game:");
            Console.WriteLine("Do you want to play snake ladder");
            snakeladder = Console.ReadLine();

            if (snakeladder == "yes")
            {
                Random random = new Random();
                int randomnumber = random.Next(1, 7);
                Console.WriteLine("throwing a dice.....number is:" + randomnumber);
            }
            else
            {
                Console.WriteLine("player choose not to play");
            }
        }
    }
    }
}
