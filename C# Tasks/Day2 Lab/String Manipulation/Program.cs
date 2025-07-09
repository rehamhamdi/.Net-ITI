namespace String_Manipulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a sentence: ");
            string sentence = Console.ReadLine().ToLower();

            int count = 0;

            foreach (char c in sentence)
            {
                if ("aeiou".Contains(c))
                {
                    count++;
                }
            }

            Console.WriteLine("Number of vowels: " + count);
        }
    }
}
