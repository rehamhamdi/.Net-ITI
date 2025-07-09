namespace Jagged_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of students: ");
            int n = int.Parse(Console.ReadLine());

            int[][] marks = new int[n][];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\nStudent {i + 1}:");

                Console.Write("Enter number of subjects: ");
                int subjectCount = int.Parse(Console.ReadLine());

                marks[i] = new int[subjectCount];

                int total = 0;

                for (int j = 0; j < subjectCount; j++)
                {
                    Console.Write($"Enter mark for subject {j + 1}: ");
                    marks[i][j] = int.Parse(Console.ReadLine());
                    total += marks[i][j];
                }

                double average = (double)total / subjectCount;

                Console.WriteLine($"Total Marks: {total}");
                Console.WriteLine($"Average Marks: {average:F2}");
            }
        }
    }
}
