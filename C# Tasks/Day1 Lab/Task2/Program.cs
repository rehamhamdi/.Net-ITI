namespace Task2_Solution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int intial_balance = 1000;
            int option;
            Console.WriteLine("Welcome to the ATM!");
            do
            {
                Console.WriteLine("\n1. Check Balance\n2. Deposit\n3. Withdraw\n4. Exit\n");
                Console.Write("Choose an option: ");
                option = int.Parse(Console.ReadLine());

                if (option == 1)
                {
                    Console.WriteLine($"your Balance is: {intial_balance}");
                }
                else if (option == 2)
                {
                    Console.Write("Enter amount to deposit: ");
                    int deposit = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Balance is now: {intial_balance + deposit}");
                }
                else if (option == 3)
                {
                    Console.WriteLine("enter amount to withdraw");
                    int withdraw = int.Parse(Console.ReadLine());
                    if (withdraw > intial_balance)
                    {
                        Console.WriteLine("you can not withdraw amount more than your balance");
                    }
                    else { Console.WriteLine("the withdraw opration is done succefully"); }
                }
            } while (option != 4);
        }
    }
}
