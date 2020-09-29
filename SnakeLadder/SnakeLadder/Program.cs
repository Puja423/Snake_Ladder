using System;
using System.Threading;

namespace SnakeLadder
{
    class Program
    {
        static void Main(string[] args)
        {
            string snakeladder = null;
            int s = 0;
            int max = 100;
            int cuurent_score = 0;
            int currentposition = s;

            Console.WriteLine("Welcome to  snakeladder Game");
            Console.WriteLine("Do you want to play snakeladder");
            snakeladder = Console.ReadLine();
            if (snakeladder.Equals("yes"))
            {


                while (cuurent_score != 100)
                {

                
                        Random random = new Random();
                        int randomnumber = random.Next(1, 7);
                        Console.WriteLine("throwing a dice.....:Number is --->" + randomnumber);
                        Random random1 = new Random();//snake
                        int randomnumber1 = random1.Next(1, 4);
                        /**
                         *If number is 1 --> Player Chooses No Step
                         *If number is 2--> You got bitten by snake and will move backward with the obtained by dice
                         *if number is 3---> player choose to play and forward
                         * 
                         */
                        if (randomnumber1 == 1)
                        {
                            Console.WriteLine("Player Chooses not to move any step and current position is " + cuurent_score);

                        }
                        else if (randomnumber1 == 2)
                        {
                            Console.WriteLine("Player got bitten by snake");
                            if (cuurent_score < 6)
                            {
                                cuurent_score = 0;
                            }
                            else
                            {

                                cuurent_score = cuurent_score - randomnumber;

                            }
                            Console.WriteLine("new Player Position --> " + cuurent_score);

                        }
                        else
                        {
                       
                        {
                            int newsum = cuurent_score + randomnumber;
                            if (newsum <= 100)
                            {
                                cuurent_score = newsum;
                            }

                            Console.WriteLine("new Player Position --> " + cuurent_score);
                           
                        }

                    }
                }

            }


            else
            {
                Console.WriteLine("Player chooses not to play");
            }

        }
    }
    
}
