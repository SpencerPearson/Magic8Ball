using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Monday
{
    class Magic8Ball
    {
        static void Main(string[] args)
        {
            /*
            * REQUIREMENTS:
            * 1. Ask the user for their yes/no question
            * 2. Respond with a random answer from your set (collection of answers).
            * 3. Set the program to loop based on user choice
            */
            Console.WriteLine("Magic 8 Ball Version 1.1");
            Console.WriteLine("" +
                @"        ____
    ,dP9CGG88@b,
  ,IP  _   Y888@@b,
 dIi  (_)   G8888@b
dCII  (_)   G8888@@b
GCCIi     ,GG8888@@@
GGCCCCCCCGGG88888@@@
GGGGCCCGGGG88888@@@@...
Y8GGGGGG8888888@@@@P.....
 Y88888888888@@@@@P......
 `Y8888888@@@@@@@P'......
    `@@@@@@@@@P'.......
        """"........");
            Console.Title = "Magic 8 Ball";
            string[] ballAnswers = { "It is certain", "Without a doubt", "You may rely on it", "Yes, definitely", "It is decidedly so", "As I see it, yes", "Most likely", "Yes", "Outlook good", "Signs point to yes", "Reply hazy try again", "Better not tell you now", "Ask again later", "Cannot predict now", "Concentrate and ask again", "Don't count on it", "Outlook not so good", "My sources say no", "Very Doubtful", "My reply is no" };
            bool confirm = false;
            while (!confirm)
            {
                Console.WriteLine("Ask your yes or no question: ");
                string question = Console.ReadLine();
                Console.Clear();
                while (!confirm)
                {
                    Console.WriteLine("You asked: \"{0}\", is that correct?", question);
                    Console.Write("Type 'C' to confirm or any other key to go back: ");
                    ConsoleKey userChoice = Console.ReadKey(true).Key;
                    switch (userChoice)
                    {
                        case ConsoleKey.C:
                            Console.Clear();
                            confirm = true;
                            Console.WriteLine("Your question is confirmed. Shaking the 8 ball...");
                            System.Threading.Thread.Sleep(2000);
                            break;
                        default:
                            Console.Clear();
                            Console.WriteLine("Ok, you can try again!\nAsk your yes or no question: ");
                            question = Console.ReadLine();
                            //goto ask;
                            break;
                    }
                }
                bool look = false;
                int shakes = 1;
                while (!look)
                {

                    Random rand = new Random();
                    int currentRoll = rand.Next(1, 21);
                    Console.Clear();
                    Console.WriteLine("You shook the 8 ball {0} time{1}, shake again?", shakes, shakes == 1 ? "" : "s");
                    Console.WriteLine("Type 'S' to shake again or 'L' to look at your answer.");
                    ConsoleKey shakeChoice = Console.ReadKey(true).Key;
                    switch (shakeChoice)
                    {
                        case ConsoleKey.S:
                            Console.Clear();
                            Console.WriteLine("Shake, shake, shake!");
                            System.Threading.Thread.Sleep(1200);
                            currentRoll = rand.Next(1, 21);
                            shakes++;
                            continue;
                        case ConsoleKey.L:
                            Console.Clear();
                            Console.WriteLine("The blue answer die floats toward the viewing window...");
                            System.Threading.Thread.Sleep(2000);
                            Console.WriteLine($"\"{ballAnswers[currentRoll]}\"");
                            look = true;
                            break;
                        default:
                            Console.WriteLine("Input invalid, please try again.");
                            System.Threading.Thread.Sleep(2000);
                            Console.Clear();
                            continue;
                    }
                }
                System.Threading.Thread.Sleep(2000);
                Console.Write("Would you like to ask another question? Y/N: ");
                ConsoleKey yesOrNo = Console.ReadKey(true).Key;
                bool problemChild = true;
                while (problemChild)
                {
                    switch (yesOrNo)
                    {
                        case ConsoleKey.Y:
                            Console.Clear();
                            confirm = false;
                            problemChild = false;
                            break;
                        case ConsoleKey.N:
                            Console.WriteLine("Thanks for playing. Goodbye!");
                            problemChild = false;
                            break;
                        default:
                            Console.Clear();
                            Console.WriteLine("Invalid input, please try again.");
                            System.Threading.Thread.Sleep(2000);
                            continue;
                    }
                }
            }
        }
    }
}
