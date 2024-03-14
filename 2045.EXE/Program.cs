using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace textAdventure2
{
    
    class Program
    {
        private static bool secText;
        private static int moneyRich;

        public static void Main(string[] args)
        {
            gameTitle();
            fifth();
            fourth();
            first();
            sixth();
        }

        

        /* I hate Developing sometimes i spent 3 hours working on this while havig to go to school and homework */
        public static void gameTitle()
        {
            Console.Title = "2045";
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("Hey this in the beginning of 2045.");
            Console.WriteLine("Write down info you gained or type it in a notepad or any text editor \n Please don't pirate this");
            Console.WriteLine("Press 'Enter' to begin.");
            Console.ReadLine();
            Console.Clear();
            first();

        }
        public static void first()
        {
            
            
            
            
            
            string choice;

            Console.WriteLine("You need to get in the united union");
            Console.WriteLine("What do you do?");
            Console.WriteLine("1. sign up to get a citizen paper");
            Console.WriteLine("2. Add yourself to the citizen illegally.");
            Console.WriteLine("3. Sneak in through trucks.");
            Console.Write("Choice: ");

            choice = Console.ReadLine().ToLower();

            Console.Clear();

            switch (choice)
            {
                case "1":
                case "sign up to get a citizen paper":
                case "sign":
                    {
                        Console.WriteLine("You walk up to the accepting booth.");
                        Console.WriteLine("If you get rejected you will get executed.");
                        Console.WriteLine("You are the next one in line you are so close to getting into a better place.");
                        Console.WriteLine("Soon you notice the person in front didn't get accepted.");
                        Console.WriteLine("You get to the line and the first thing he says is rejected.");
                        Console.WriteLine("Unfortunately there is no escape.");
                        Console.WriteLine("You are loaded onto a truck to never be seen again.");
                        Console.ReadLine();
                        first();
                        gameOver();
                        break;
                }
                case "2":
                case "Add yourself to the citizen illegally.":
                    {
                        Console.WriteLine("You add yourself to the citizen database.");
                        Console.WriteLine("you walk to the booth and you tell him you went out of country for a business venture.");
                        Console.WriteLine("He says ok and he lets you in to the United Union.");
                        Console.ReadLine();
                        second();
                        break;
                    }
                case "3":
                case "Sneak":
                case "Sneak in through trucks.":
                    {
                        Console.WriteLine("You gather materials to sneak in through the survey trucks.");
                        Console.WriteLine("You get in and all is well. ");
                        Console.WriteLine("You get to the border where they check the trucks. \n The border guard finds and then you are loaded onto a truck to never be seen again. "); ;
                        Console.ReadLine();
                        first();
                        gameOver();
                        break;
                    }
         
        static void gameOver()
        {
            Console.Clear();
            Console.WriteLine("You have died.");
            Console.WriteLine("");
            Console.WriteLine("The End?");
            Console.ReadLine();
            Console.Clear();
            gameTitle();
        }

        static void youWin()
        {
            Console.Clear();
            Console.WriteLine("You have survived.");
            Console.WriteLine("A group of rangers spot you.");
            Console.WriteLine("You are saved.");
            Console.ReadLine();
            Console.Clear();
            gameTitle();
        }
                    }
            }

        

        public static void second()
        {
            Console.WriteLine();
            Console.WriteLine("Do you want to dig through the wallet?");
            Console.Write("Choice: ");

            string secChoice;
            secChoice = Console.ReadLine().ToLower();

            if (secChoice == "yes" || secChoice == "y")
            {
              
                 Random rnd = new Random();
                 int moneyRich = rnd.Next(0, 1000);

                Console.WriteLine("You found " + moneyRich + " credits");
                Console.ReadLine();
                Console.Clear();
                fifth();

            }
            else if (secChoice == "no" || secChoice == "n")
            {
                Console.WriteLine("You walk out with no money");
                Console.WriteLine("What do you want to do?");
                Console.ReadLine();
                fourth();

            }
            else
            {
                Console.WriteLine("You must reply Yes or no.");
                Console.WriteLine("Press 'Enter' to continue.");
                Console.ReadLine();
                second();
            }

        }

        public static void third()
        {
           int Decision;
            Console.WriteLine("");
            Console.WriteLine("your stomach sinks and your eyes go wide as you scan the direction of the sound");
            Console.WriteLine("Will you fight or flee? Type 1 or 2.");
            Console.Write("Decision: ");
            int.TryParse(Console.ReadLine(), out Decision);
            int loop = 0;
            bool dead = false;
            while (Decision != 1 && dead == false)
            {
                if (loop <= 0)
                {
                    Console.WriteLine("You are too slow, a large bear leaps out and claws you in the chest.");
                    Console.WriteLine("You are bleeding profusely now, will your flee or fight?");
                    Console.Write("Decision: ");
                    int.TryParse(Console.ReadLine(), out Decision);
                    loop ++ ;
                }
                else if (loop >= 1)
                {
                    Console.WriteLine("The bear grabs you by your pants, you are kicking and screaming.");
                    Console.WriteLine("Fear and adrenaline surge with in you. Fight or Flee? 1 or 2? ");
                    Console.Write("Decision: ");
                    int.TryParse(Console.ReadLine(), out Decision);
                    dead = true;
                }
               
            }
            if (dead == true )
                {
                Console.WriteLine("You feel a sharp claw swipe your back , and jagged teeth tear at your legs");
                Console.WriteLine("All is pain, followed by darkness.");
                Console.ReadLine();
                gameOver();
                }
            else 

                {
                Console.WriteLine("You fight with all your might, punching the bear in the nose and causing it to flee.");
                Console.ReadLine();
                youWin();
                }
        }
        
        

        public static void youWin()
        {
            Console.Clear();
            Console.WriteLine("You have won my game good job.");
            Console.WriteLine("Thanks so much for playing - CSstudios");
            Console.WriteLine("Bye replay if you want.");
            Console.ReadLine();
            Console.Clear();
            gameTitle(); 
        }

        public static void gameOver()
        {
           Console.Clear();
            Console.WriteLine("You have died.");
            Console.WriteLine("");
            Console.WriteLine("The End?");
            Console.ReadLine();
            Console.Clear();
            gameTitle();
        }
        public static void fourth()
        {
            string choice;

            Console.WriteLine("You are pretty hungry ");
            Console.WriteLine("What do you do?");
            Console.WriteLine("1. buy food and drink");
            Console.WriteLine("3. Just stay hungry");
            Console.Write("Choice: ");

            choice = Console.ReadLine().ToLower();

            Console.Clear();

            switch (choice)
            {
                case "1":
                case "sign up to get a citizen paper":
                case "sign":
                    {
                        Console.WriteLine("You walk up to the store and enter.");
                        Console.WriteLine("You walk to the store");
                        Console.WriteLine("You are the next one in line you are so close to getting into a better place.");
                        Console.WriteLine("Soon you notice the person in front didn't get accepted.");
                        Console.WriteLine("You get to the line and the first thing he says is rejected.");
                        Console.WriteLine("Unfortunately there is no escape.");
                        Console.WriteLine("You are loaded onto a truck to never be seen again.");
                        Console.ReadLine();
                        sixth();
                        break;
                }
                case "2":
                case "Add yourself to the citizen illegally.":
                    {
                        Console.WriteLine("You add yourself to the citizen database.");
                        Console.WriteLine("you walk to the booth and you tell him you went out of country for a business venture.");
                        Console.WriteLine("He says ok and he lets you in to the United Union.");
                        Console.ReadLine();
                        second();
                        break;
                    }
                case "3":
                case "Sneak":
                case "Sneak in through trucks.":
                    {
                        Console.WriteLine("You gather materials to sneak in through the survey trucks.");
                        Console.WriteLine("You get in and all is well. ");
                        Console.WriteLine("You get to the border where they check the trucks. \n The border guard finds and then you are loaded onto a truck to never be seen again. "); ;
                        Console.ReadLine();
                        first();
                        gameOver();
                        break;
                    }
            }
        }
    public static void fifth()
    {
        Random rnd = new Random();
            string[] Text = { "You see a wallet on the ground you need some credits and you want to dig through the wallet. Will you "};
            
            int moneyCredit = rnd.Next(0, 10000);

        Console.WriteLine("What do you want to do since you have " + moneyCredit + "  ");
        
    }
    public static void sixth()
    {
        string choice;

            Console.WriteLine("You are pretty hungry ");
            Console.WriteLine("What do you do?");
            Console.WriteLine("1. steal food from the store?");
            Console.WriteLine("2. just stay hungry");
            Console.WriteLine("3. beg for money");
            Console.Write("Choice: ");

            choice = Console.ReadLine().ToLower();

            Console.Clear();

            switch (choice)
            {
                case "1":
                case "sign up to get a citizen paper":
                case "sign":
                    {
                        Console.WriteLine("You walk up to the store and enter.");
                        Console.WriteLine("You walk to the ");
                        Console.WriteLine("You are the next one in line you are so close to getting into a better place.");
                        Console.WriteLine("Soon you notice the person in front didn't get accepted.");
                        Console.WriteLine("You get to the line and the first thing he says is rejected.");
                        Console.WriteLine("Unfortunately there is no escape.");
                        Console.WriteLine("You are loaded onto a truck to never be seen again.");
                        Console.ReadLine();
                        sixth();
                        gameOver();
                        break;
                }
                case "2":
                case "Add yourself to the citizen illegally.":
                    {
                        Console.WriteLine("You add yourself to the citizen database.");
                        Console.WriteLine("you walk to the booth and you tell him you went out of country for a business venture.");
                        Console.WriteLine("He says ok and he lets you in to the United Union.");
                        Console.ReadLine();
                        second();
                        break;
                    }
                case "3":
                case "Sneak":
                case "Sneak in through trucks.":
                    {
                        Console.WriteLine("You gather materials to sneak in through the survey trucks.");
                        Console.WriteLine("You get in and all is well. ");
                        Console.WriteLine("You get to the border where they check the trucks. \n The border guard finds and then you are loaded onto a truck to never be seen again. "); ;
                        Console.ReadLine();
                        first();
                        gameOver();
                        break;
                    }
            }
        }
    }
}
