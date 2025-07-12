namespace Separate_Even_and_Odd_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.Write("Enter size of array: ");
            int size = int.Parse(Console.ReadLine());
            int[] array = new int[size];
            Console.WriteLine("Enter Scores: ");
            int s = 0;
            for (int i = 0; i < size; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            SeparateEvenOdd(array,out int[] even ,out int[] odd);
            for (int i=0; i < even.Length; i++)
            {
                Console.WriteLine($"The Even Numbers in the array: {even[i]}");
            }
            for (int i = 0; i < odd.Length; i++)
            {
                Console.WriteLine($"The Odd Numbers in the array: {odd[i]}");
            }
        }

        static void SeparateEvenOdd(int[] input, out int[] evenNumbers, out int[] oddNumbers)
        {
            int countEven = 0;
            int countOdd = 0;
            
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] % 2 == 0)
                {
                    countEven++;
                }
                else
                {
                    countOdd++;
                }
            }
            evenNumbers = new int[countEven];
            oddNumbers = new int[countOdd];

            int eIndex = 0, oIndex = 0;
            foreach (int num in input)
            {
                if (num % 2 == 0)
                    evenNumbers[eIndex++] = num;
                else
                    oddNumbers[oIndex++] = num;
            }

        }
    }
}
