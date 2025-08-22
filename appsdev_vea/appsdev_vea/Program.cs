using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Voting Eligibility Application Requirements: ");

        Console.Write("Enter your age: ");
        string ageInput = Console.ReadLine();

        int age;
        if (!int.TryParse(ageInput, out age))
        {
            Console.WriteLine("Invalid age. Please enter a number.");
            return; // stop program
        }

        Console.Write("Are you a Filipino citizen? (yes/no): ");
        string citizen = Console.ReadLine().ToLower();

        if (age >= 18 && citizen == "yes")
        {
            Console.WriteLine("You are eligible to vote!");
        }
        else
        {
            Console.WriteLine("You are not eligible to vote.");
        }

        Console.WriteLine("Press any key to exit..");
        Console.ReadKey();
    }
}
