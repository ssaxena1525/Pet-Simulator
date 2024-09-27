internal class Program
{
    private static void Main(string[] args)
    {
        bool majorMain = false;
        string petName = "";
        string petType = "";
        while (!majorMain)
        {

            Console.WriteLine("Welcome to Virtual Pet Simulator");

            Console.WriteLine("Please choose a type of pet (Name or Number): ");
            Console.WriteLine("1. Cat:");
            Console.WriteLine("2. Dog:");
            Console.WriteLine("3. Rabbit:");
            Console.Write("User Input: ");
            petType = Console.ReadLine();
            if (petType == "1" || petType == "cat" || petType == "Cat")
            {
                petType = "Cat";
                Console.WriteLine("You have choosen a " + petType + ".\nWhat would you like to name your pet?");
                Console.Write("User Input: ");
                petName = Console.ReadLine();
                Console.WriteLine("Welcome " + petName + "! Let's take good care of him");
                majorMain = true;
            }
            else if (petType == "2" || petType == "dog" || petType == "Dog")
            {
                petType = "Dog";
                Console.WriteLine("You have choosen a " + petType + " What would you like to name him");
                Console.Write("User Input: ");
                petName = Console.ReadLine();
                Console.WriteLine("Welcome " + petName + "! Let's take good care of him");
                majorMain = true;
            }
            else if (petType == "3" || petType == "rabbit" || petType == "Rabbit")
            {
                petType = "Rabbit";
                Console.WriteLine("You have choosen a " + petType + " What would you like to name him");
                Console.Write("User Input: ");
                petName = Console.ReadLine();
                Console.WriteLine("Welcome " + petName + "! Let's take good care of him");
                majorMain = true;
            }
            else
            {
                Console.WriteLine("Invalid Option choose again!");
                Console.WriteLine();
            }
        }

        int hunger = 5;
        int happiness = 5;
        int health = 5;

        bool exit = false;
        while (!exit)
        {
            hunger++;
            happiness--;
            health--;

            Console.WriteLine("\nMain Menu:");
            Console.WriteLine("1. Feed Pet");
            Console.WriteLine("2. Play with pet");
            Console.WriteLine("3. Let Pet Rest");
            Console.WriteLine("4. Check Pet Status");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                hunger = hunger - 2;
                happiness = happiness + 1;
                health = health + 1;
                Console.WriteLine(petName, "'s Status");
                Console.Write("\n");
                Console.WriteLine("Happiness: " + happiness);
                Console.WriteLine("Hunger: " + hunger);
                Console.WriteLine("Health: " + health);
                Console.WriteLine();
            }
            else if (choice == "2")
            {
                happiness = happiness + 2;
                hunger = hunger + 1;
                Console.WriteLine(petName, "'s Status");
                Console.Write("\n");
                Console.WriteLine("Happiness: " + happiness);
                Console.WriteLine("Hunger: " + hunger);
                Console.WriteLine("Health: " + health);
                Console.WriteLine();
            }
            else if (choice == "3")
            {
                health = health + 1;
                hunger = hunger + 1;
                happiness = happiness - 1;
                Console.WriteLine(petName, "'s Status");
                Console.Write("\n");
                Console.WriteLine("Happiness: " + happiness);
                Console.WriteLine("Hunger: " + hunger);
                Console.WriteLine("Health: " + health);
                Console.WriteLine();
            }
            else if (choice == "4")
            {
                Console.WriteLine();
                Console.WriteLine(petName + "'s Current Status: \n");
                Console.WriteLine("Happiness: " + happiness + "\nHunger = " + hunger + "\nHealth: " + health);
            }

            else if (choice == "5")
            {
                Console.WriteLine("Thank you for using the pet simulator!");
                exit = true;
            }

            else
            {
                Console.WriteLine("Invalid Choice Try Again");
                Console.Clear();
            }

            if (hunger <= 2)
            {
                Console.WriteLine("Warning: Hunger is critically low!");
                health--;
            }
            if (happiness <= 3)
            {
                Console.WriteLine("Warning: Happiness is critically low!");
                health--;
            }
            if (health <= 0)
            {
                Console.WriteLine("Your pet has become unwell due to neglect. Game Over!");
                Environment.Exit(0);
            }
        }   

    }
}