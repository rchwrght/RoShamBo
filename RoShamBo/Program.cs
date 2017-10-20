using System;

namespace RoShamBo
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("This is a simple Rock, Paper Scissors Program\n");
            int wins = 0;
            int loses = 0;
            int draws = 0;
            while(true) {
                Console.WriteLine("So chose your weapon and see if you can beat me!");
                string input = Console.ReadLine().ToLower();
                string[] response = new string[] {"rock", "paper", "scissors"};
                Random RandomNumber = new Random();
                int rng = RandomNumber.Next(3);
                string computer = response[rng];
                if(String.Equals(input, computer)){ //Draw Conditions
                    Console.WriteLine("Player Chose: " + input);
                    Console.WriteLine("Computer Chose: " + computer);
                    Console.WriteLine("We Drew");
                    draws++;
                } else if ((input == "rock" && computer == "scissors") || (input == "scissors" && computer == "paper") || (input == "paper" && computer == "rock")){ //Win Conditions
                    Console.WriteLine("Player Chose: " + input);
                    Console.WriteLine("Computer Chose: " + computer);
                    Console.WriteLine("Dang you beat me!");
                    wins++;
                } else if ((input == "rock" && computer == "paper") || (input == "paper" && computer == "scissors") || (input == "scissors" && computer == "rock")){ //Lose Conditions
                    Console.WriteLine("Player Chose: " + input);
                    Console.WriteLine("Computer Chose: " + computer);
                    Console.WriteLine("HAHA You suck, you sucky human!");
                    loses++;
                } else {
                    Console.WriteLine("You have not entered a viable weapon");
                }
                Console.WriteLine("Your current record is:\n");
                Console.WriteLine(wins + "-" + loses + "-" + draws);
                Console.WriteLine("Would you like to try again?\nYes or No");
                string answer = Console.ReadLine().ToLower();
                if(answer != "yes"){
                    break;
                }
            }
        }
    }
}