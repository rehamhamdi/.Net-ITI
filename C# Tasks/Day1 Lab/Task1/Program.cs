namespace Tasks_Solution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many numbers will you enter? ");
            int enter_number = int.Parse(Console.ReadLine());
            int sum = 0;
            int count_even = 0;
            int count_odd = 0;
            int x;
            int max = 0, min = 100000;
            for (int i = 0; i < enter_number; i++)
            {
                Console.Write($"Enter number {i + 1}: ");
                x = int.Parse(Console.ReadLine());
                sum += x;
                if (x % 2 == 0) count_even++;
                else count_odd++;
                if (x > max) max = x;
                if (x < min) min = x;
            }

            if (count_even > count_odd)
                Console.WriteLine("Most of your numbers are even.");
            else Console.WriteLine("Most of your numbers are odd.");
            Console.WriteLine($"Sum: {sum}");
            int average = sum / enter_number;
            Console.WriteLine($"Average: {average}");
            Console.WriteLine($"Max: {max}");
            Console.WriteLine($"Min: {min}");

        }
    }
}
