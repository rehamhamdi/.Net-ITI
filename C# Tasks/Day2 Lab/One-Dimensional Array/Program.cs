namespace One_Dimensional_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many numbers? ");
            int numbers = int.Parse(Console.ReadLine());
            int[] array = new int[numbers];

            Console.WriteLine("Enter numbers: ");
            for (int i = 0; i < numbers; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            // Step 1: Identify prime numbers
            Console.Write("Prime numbers: ");
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (IsPrime(array[i]))
                {
                    Console.Write(array[i] + " ");
                    sum += array[i];
                }
            }

            Console.WriteLine($"\nSum of primes: {sum}");

            // Step 2: Sort in descending order
            Array.Sort(array);
            Array.Reverse(array);

            Console.Write("Sorted array: ");
            foreach (int num in array)
            {
                Console.Write(num + " ");
            }
        }

        //function to check if a number is prime
        static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            for (int i = 2; i * i <= number; i++)
            {
                if (number % i == 0)
                    return false;
            }
            return true;
        
    }
}
}
