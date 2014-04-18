using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessThatNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess a number between 1-100");
            string rawInput = Console.ReadLine();
            Console.WriteLine("You wrote: " + rawInput);
            var rawNum = Convert.ToInt32(rawInput);
            GuessThatNumber(rawNum);


            Console.WriteLine("Would you like to play the game again?");
            string yesOrNoRaw = Console.ReadLine();
            string yesOrNo = yesOrNoRaw.ToLower();

            if (yesOrNo == "yes")
            {
                Console.WriteLine("Guess a number between 1-100");
                rawInput = Console.ReadLine();
                Console.WriteLine("You wrote: " + rawInput);
                rawNum = Convert.ToInt32(rawInput);
                GuessThatNumber(rawNum);
            }
            else if (yesOrNo == "no")
            {
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Please pick 'yes' or 'no'.");
            }

        }



        static void GuessThatNumber(int input)
        {
            //Define varrables
            var num = Convert.ToInt32(input);
            var randomTemp = new Random();
            var random = randomTemp.Next(1, 101);
            var correctNum = true;
            var attempts = 0;

            //Waits until correctNum is true to finsish the script, which only happens when you guess the correct number
            while (correctNum)
            {
                //If you picked the correct number
                if (num == random)
                {
                    //Prints that you won...
                    Console.WriteLine("Congratulations! You guessed the correct number!");
                    //Prints How many attempts that you took
                    Console.WriteLine("Your number of attempts were: " + attempts);
                    //makes correctNum false so the while loop continues
                    correctNum = false;
                }
                //If the number is not correct...
                else
                {
                    //Checks if the picked number is less than the random number
                    if (num < random)
                    {
                        if(num == random)
                        //...
                        Console.WriteLine("That is not the correct number. Guess again.");
                        //Says where you are in relation to the random number
                        Console.WriteLine("You're number is too low!");
                        //Adds an attempt to be desplayed at the end
                        attempts++;
                        //Lets the user pick another number
                        string input2 = Console.ReadLine();
                        //..And converts it to an int
                        num = Convert.ToInt32(input2);
                    }
                    //Checks if the picked number is more than the random number
                    else if (num > random)
                    {
                        //See last if statement
                        Console.WriteLine("That is not the correct number. Guess again.");
                        Console.WriteLine("You're number is too high!");
                        attempts++;
                        string input2 = Console.ReadLine();
                        num = Convert.ToInt32(input2);
                    }
                }
            }
        }
    }
}
