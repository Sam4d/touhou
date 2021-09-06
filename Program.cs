using System;

namespace Conditions
{
    class Program
    {
        static void Main(string[] args)
        {
        
        //if & else or else if statements require you to add {} and have the process in them.
            
            Console.Title = ("Touhou Cafe Simulator x64 (Build 14393.3204)");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Welcome to Touhou Cafe! Headpats are 5$, want some? UmU");
   
            Console.ForegroundColor = ConsoleColor.White;
            
            double cash = Convert.ToDouble(Console.ReadLine() );

        // here's a simple cash counter with if and else if statement (3 conditions)
        
        // 1) if cash is less than 5, gimme more money action appears.
        // 2) if cash is equal to 5, headpat action appears.
        // 3) if cash is more than 5, she gives the change.

        // this entire program has custom foregroud colors added to it for adding more life to it.

            if (cash < 5)
            {   Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Gimme more money you cheap fuck.");
            }
            else if (cash == 5)
            {   Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Here are your headpats Goshujin Sama!");
            }
            else
            {
                double change = cash - 5;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Thanks Goshujin Sama!, here's " + change + "$, your change ^^");
            }
            
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Now lets check your age, What is your age in years?");
            
            Console.ForegroundColor = ConsoleColor.White;
            double age = Convert.ToDouble(Console.ReadLine() );

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Also lets check your height! What is your height? (ft)");
            
            Console.ForegroundColor = ConsoleColor.White;
            double height = Convert.ToDouble(Console.ReadLine() );

        // && = and the number of conditions met.
        // || = or the number of conditions met.

            if (age >= 20 && height >= 6) {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Holy shit you're totally my type X)");
            }
            else {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Fuck off, you don't deserve fun.");
                
            }
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Now time for a quickie test UmU, tell me what is 2+2?");
            
            Console.ForegroundColor = ConsoleColor.White;
            int answer = Convert.ToInt32(Console.ReadLine() );

            if (answer == 4) {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Smartest Senpai in the Town I see X)");
            }

            else {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You deserve to be stoned.");
            }
            

        //Switch statements are statements which can have multiple values applied to a single variable
        //Its upto the user to select whichever mode they prefer (either if/else or switch)
                
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Do you have any age prefrences?");
                
                Console.ForegroundColor = ConsoleColor.White;
                int awoo = Convert.ToInt32(Console.ReadLine() );

            switch (awoo) {
                case >= 18:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Meh, I thought you were a man of culture ;-;");
                    break;
                case < 18: 
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Nice! We got him officer :D");
                    break;
            }

                 Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Do you wanna know about anything in anime? Feel free to ask!");
            
            Console.ForegroundColor = ConsoleColor.White;
            string umu = Convert.ToString(Console.ReadLine() );

            switch (umu) {
                case "what is a neko?":
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Cats who are fuckable, literally.");
                    break;
                case "what is a wolfgirl?": 
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Wolves who are fuckable.");
                    break;
            }



            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            Console.ReadKey();    
        }
    }
}
