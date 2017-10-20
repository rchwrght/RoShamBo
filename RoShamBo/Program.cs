using System;

namespace RoShamBo
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("This is a simple Rock, Paper Scissors Program\n");
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
                } else if ((input == "rock" && computer == "scissors") || (input == "scissors" && computer == "paper") || (input == "paper" && computer == "rock")){ //Win Conditions
                    Console.WriteLine("Player Chose: " + input);
                    Console.WriteLine("Computer Chose: " + computer);
                    Console.WriteLine("Dang you beat me!");
                } else {
                    Console.WriteLine("Player Chose: " + input);
                    Console.WriteLine("Computer Chose: " + computer);
                    Console.WriteLine("HAHA You suck, you sucky human!");
                }
                Console.WriteLine("Would you like to try again?\nYes or No");
                string answer = Console.ReadLine().ToLower();
                if(answer != "yes"){
                    break;
                }
            }
        }
    }
}
