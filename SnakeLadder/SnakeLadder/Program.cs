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
                Random random1 = new Random();
                int randomnum1 = random.Next(1, 4);
                /**
                     *If number is 1-- > Player Chooses No Step
                      * If number is 2-- > You got bitten by snake and will move backward with the obtained by dice
                        *if number is 3--->player choose to play and forward
                        */
                if (randomnum1 == 1)
                {
                    Console.WriteLine("player choose not to move any step:" + current_score);

                }
                else if (randomnum1 == 2)
                {
                    Console.WriteLine("player got bitten by snake");
                    if (current_score < 6)
                    {
                        current_score = 0;
                    }
                    else
                    {
                        current_score = current_score - randomnum1;
                    }
                    Console.WriteLine("current position....:" + current_score);
                }
                else
                {
                    int newsum = current_score + randomnumber;
                    if (newsum < 100)
                    {
                        current_score = newsum;
                    }

                    Console.WriteLine("new Player Position --> " + current_score);


                }

            }
            else
            {
                Console.WriteLine("player choose not to play");
            }
        }
    }
    
}
