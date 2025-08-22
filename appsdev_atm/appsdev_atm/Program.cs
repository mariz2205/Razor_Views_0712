using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8; // allow peso sign ₱
        double balance = 0;

        while (true)
        {
            Console.WriteLine("\nATM");
            Console.WriteLine("1. Deposit");
            Console.WriteLine("2. Withdraw");
            Console.WriteLine("3. Check Balance");
            Console.WriteLine("4. Exit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.Write("Enter amount to deposit: ");
                double deposit = double.Parse(Console.ReadLine());
                balance += deposit;
                Console.WriteLine($"Deposited ₱{deposit}. New balance: ₱{balance}");
            }
            else if (choice == "2")
            {
                Console.Write("Enter amount to withdraw: ");
                double withdraw = double.Parse(Console.ReadLine());

                if (withdraw > balance)
                {
                    Console.WriteLine("Insufficient balance!");
                }
                else
                {
                    balance -= withdraw;
                    Console.WriteLine($"Withdrew ₱{withdraw}. New balance: ₱{balance}");
                }
            }
            else if (choice == "3")
            {
                Console.WriteLine($"Your current balance is: ₱{balance}");
            }
            else if (choice == "4")
            {
                Console.WriteLine("Thank you for using ATM!");
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice, please try again.");
            }
        }
    }
}
