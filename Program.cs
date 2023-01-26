using System;

namespace Text_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Title();
        }
       
        public static void Title()
        {
            Console.Write("Welcome! Welcome! \n");
            Console.Write("What a bold choice, playing some random text adventure game, huh?");
            Confirm();
            Console.Write("What is your name, bold player?: ");
            string namePlayer = Console.ReadLine();
            Console.WriteLine($"Hello, {namePlayer}! Welcome to our story.\n");
            Confirm();
            One();
        }
        public static void Confirm()
        {
            Console.ReadLine();
            Console.Clear();
        }
        public static void One()
        {
            Console.WriteLine("It begins on a normal school day. You're sitting in a chair and think of going to the Appie.\nDo you go?");
            Console.Write(" 1. Yes!\n 2. Maybe?\n 3. No... \n Choice (1-3): ");
            string choice = Console.ReadLine().ToLower();
            Console.Clear();
            switch (choice)
            {
                case "1":
                    {
                        Console.WriteLine("Great! Finally someone who actually does stuff!");
                        Console.WriteLine("You grab your phone and walks confidently to the appie.");
                        MarketScene();
                        break;
                    }
                case "2":
                    {
                        Console.WriteLine("What do you mean MAYBE????");
                        Console.WriteLine("Listen, I don't care what kind of fear you have, you WILL go.");
                        MarketScene();
                        break;
                    }
                case "3":
                    {
                        Console.WriteLine("God, you're such a scared cat.");
                        Console.WriteLine("Fine, give up then.");
                        Confirm();
                        Console.WriteLine("What do you want? Leave.");
                        Confirm();
                        GameOver();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("I don't undertand that, try again");
                        Console.WriteLine("Press enter to try again!");
                        Confirm();
                        One();
                        break;
                    }
            }
        }
        public static void MarketScene()
        {
            string item = "";
            Console.WriteLine("You enter the appie, ignoring the few customers that are on your way.\n");
            Console.WriteLine("What will you buy?");
            Console.WriteLine("1.Cookies\n2.Sauce\n3.Bread");
            string grocery = Console.ReadLine();
            if (grocery == "1")
            {
                item = "cookies";
                Console.WriteLine("When you finally get to the cookies shelf. Your hands reach to the chocolate cookies \nand you grab one package to take to the cash register.\n");
            }
            else if (grocery == "2")
            {
                item = "sauce";
                Console.WriteLine("Sauce???\nAlright, fair");
                Confirm();
                Console.WriteLine("You grab the only sauce left in the shelf.\nLuckily, it's the ceasar salad sauce. My favorite!");
            }
            else if (grocery == "3")
            {
                item = "bread";
                Console.WriteLine("You're so basic.");
                Confirm();
                Console.WriteLine("The breads are visible from very far away, so happily you don't get lost.\nYou grab the first bread you see.");
                Confirm();
                Console.WriteLine("It's a bread full of seeds and those healthy stuff. Ew.\nI'm glad I'm not the one eating that.");
                Confirm();
                Console.WriteLine("Anyways, you head to the cashier with your healthy bread on your hand.");
            }
            Console.WriteLine("However, you see a light coming from under a hidden door on the way. \n" +
                "It seems very weird, that door was never there before..." +
                "You walk towards it. \nDo you open it or knock?\n" +
                "1. Open\n" +
                "2. Knock\n");
            string door = Console.ReadLine();
            switch (door)
            {
                case "1":
                    Console.WriteLine("Bold. Very bold.");
                    Console.WriteLine("Lucky you, the door is not locked and you can open it easily.");
                    Confirm();
                    Inside();
                    break;
                case "2":
                    Console.WriteLine("You knock, but no one replies.");
                    Console.WriteLine("Maybe try to knock again?");
                    Console.WriteLine("Press enter to knock.");
                    Confirm();
                    Random rnd = new Random();
                    int random = rnd.Next(0, 2);
                    string[] options =
                    {
                        "You knock again. There is still no replies from the inside, but the cashier hears and screams for you to get out. \nGreat. Now you really need to run.",
                        "After knocking and waiting a while, no one answers. \nYou try to open the door and for your suprise the door was unlocked all this time.\n "
                    };
                    string text = options[random];
                    Console.WriteLine(text);
                    if (random == 0)
                    {
                        Confirm();
                        Console.WriteLine("DID YOU HEAR ME???\nRUN!");
                        Console.WriteLine("Roll the dice to see how you'll perform!");
                        Console.ReadLine();
                        int dice = rnd.Next(0, 20);
                        Console.WriteLine("Great, you got a " + dice);
                        Confirm();
                        if (dice < 9)
                        {
                            Console.WriteLine("Congrats, you failed terribly.\nYou try to run, but the policeman nearby blocks your way.\nYou get confronted and banned from the store.\nAt least you didn't get arrested.");
                            Confirm();
                            Console.WriteLine("Well, enough of adventures for today.");
                            Confirm();
                            GameOver();
                        }
                        else
                        {
                            Console.WriteLine("\nRun! Run!");
                            Console.WriteLine("You manage to run fast enough and escape the mad cashier.");
                            Console.WriteLine("Phew! Imagine being caught trying to enter a secret door at the appie?!");
                            Console.WriteLine("Wait...");
                            Confirm();
                            Console.WriteLine("What's that in your hand..?");
                            Confirm();
                            Console.WriteLine("Oh god, you forgot to pay for the " + item + "...");
                            Console.WriteLine("Man...");
                            Confirm();
                            Console.WriteLine("You're not a great adventurer as I thought you were.");
                            Console.WriteLine("Please. Just leave.");
                            Confirm();
                            Console.WriteLine("And pay for the damn " + item);
                            Confirm();
                            GameOver();
                        }
                    }
                    else
                    {
                        Inside();
                    }

                    break;
                default:
                    Console.WriteLine("What?\n");
                    Console.WriteLine("Press enter to try again.");
                    Confirm();
                    MarketScene();
                    break;
            }
        }
        public static void Inside()
        {
            Console.WriteLine("You enter the mysterious door. The place is empty.\nThat's so disappointing...");
            Console.WriteLine("Well, let's just pay for the cookies and go back.");
            Confirm();
            GameOver();
        }
        public static void GameOver()
        {
            Console.WriteLine("Game over!\nThanks for playing!");
        }
    } 
}