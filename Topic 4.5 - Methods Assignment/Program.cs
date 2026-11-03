using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Topic_4._5___Methods_Assignment
{
    internal class Program
    {
        public static void Joke()
        {
            Console.WriteLine("99 little bugs in the code.");
            Thread.Sleep(500);
            Console.WriteLine("99 little bugs.");
            Thread.Sleep(500);
            Console.WriteLine("Fix a bug, run it again.");
            Thread.Sleep(500);
            Console.WriteLine("100 little bugs in the code.");
        }

        public static void Joke(int numBugs)
        {
            Console.WriteLine($"{numBugs} little bugs in the code.");
            Thread.Sleep(500);
            Console.WriteLine($"{numBugs} little bugs.");
            Thread.Sleep(500);
            Console.WriteLine("Fix a bug, run it again.");
            Thread.Sleep(500);
            Console.WriteLine($"{numBugs++} little bugs in the code.");
        }

        public static void CamelDesert()
        {
            string[] camelDesert =
            {
                @"                            
　　　　　                🌸＞　　フ   
　　　　　                | 　_　 _ l        
　 　　　                ／` ミ_wノ
　　 　                 /　　　 　 |
　　　                 /　 ヽ　　 ﾉ
　 　                 │　　|　|　|
　                ／￣|　　 |　|　|
　                | (￣ヽ＿_ヽ_)__)
　                ＼二つ
                ",

                @"
                   ︵ 
                ૮(`ᴥ ⁻ 𑁬
                   |    ⸝ 〵
                  じしˍ,  )୭
　　　　　　　　　 ",

                @"
                ⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣼⣶⣶⣶⣶⡾⠋
                ⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣿⣿⣿⣿⣿⠁⠀
                ⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣄⠀⠀⣼⣿⣿⣿⠟⠛⠀⠀
                ⠀⠀⠀⠀⣰⣷⣄⡀⠀⠀⠀⠸⣦⣶⣿⣄⣼⣿⣿⣿⡇⠀⠀⠀⠀
                ⠀⠀⣠⣾⣿⣿⣿⣿⣶⣤⣤⣤⣿⣿⣿⣿⣿⣿⣿⠿⠧⠀⠀⠀⠀
                ⠐⠚⠛⠿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠏⠀⠀⠀⠀⠀⠀⠀
                ⠀⠀⠀⠀⠙⠁⠀⠀⠉⢻⡿⠛⠛⠛⠻⢿⡏⠀⠀⠀⠀⠀⠀⠀⠀
                ⠀⠀⠀⠀⠀⠀⠀⠀⠀⢈⡀⠀⠀⠀⠀⠈⠛⠀⠀⠀⠀⠀⠀⠀⠀
                ",
            };

            
        }

        static void Main(string[] args)
        {
            Console.Title = "Topic 4.5 - Methods Assignment";

            Console.OutputEncoding = System.Text.Encoding.UTF8;

            CamelDesert();

            int choice, art;

            while (true)
            {
                Console.WriteLine("Select an option: ");
                Console.WriteLine("1: ASCII Art");
                Console.WriteLine("2: Knock Knock Joke");
                Console.WriteLine("3: Exit");
                Console.WriteLine("Enter your choice (1-3): ");
                choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 1)
                {
                    Console.WriteLine("Please select an ASCII art: ");
                    Console.WriteLine("1. Cat");
                    Console.WriteLine("2. Dog");
                    Console.WriteLine("3. Bat");
                    Console.WriteLine("Enter your choice (1-3); ");
                    art = Convert.ToInt32(Console.ReadLine());
                }
                else if (choice == 2)
                {

                }
                else if (choice == 3)
                {

                }
            }


            int bugs;
            Console.Write("How many bugs are in your code: ");
            Int32.TryParse(Console.ReadLine(), out bugs);
            Console.WriteLine();
            Joke(bugs);
            Console.ReadLine();

            Console.Write("Press ENTER for a joke: ");
            Console.ReadLine();
            Console.WriteLine();
            Joke();

            Console.WriteLine();

            Console.Write("Press ENTER for another joke: ");
            Console.ReadLine();
            Console.WriteLine();
            Joke(50);
        }
    }
}

/*
Add a menu in the main method that allows the user to select which method to run.
1: ASCII Art
Take the ASCII art you used in Topic 1, and put it inside of a method. Make sure to give the method a
name so that the user knows what they are drawing:
e.g. public static void DrawBat() if the picture is of a bat.
Find 2 more examples of ASCII art and make a method to draw each for a total of 3.

2: Knock Knock Joke
Make a method that tells a knock knock joke. You can decide if you want it to be interactive (user
presses enter to proceed to each message, or something fancier) or use delays.

Advanced Extra features:
• You may wish to read ahead to loops and put your menu in a loop so that the user can select
multiple options in one run of the program.
• Super Advanced Feature: Can you figure out how to make your ASCII method accept an x and y
coordinate as parameters and then draw the ASCII drawing based on that location?
o https://sites.google.com/gotvdsb.ca/aldworth/home/ics4u/fun-with-the-console
o https://www.geeksforgeeks.org/console-setcursorposition-method-in-c-sharp/
*/
