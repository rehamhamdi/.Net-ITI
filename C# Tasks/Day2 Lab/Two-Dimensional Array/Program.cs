namespace Two_Dimensional_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter size of matrix: ");
            int size = int.Parse(Console.ReadLine());
            Console.WriteLine($"Enter {size}x{size} matrix: ");
            int[,] array = new int[size, size];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    int num = int.Parse(Console.ReadLine());
                    array[i, j] = num;
                }
            }
            Console.WriteLine("Original Matrix: ");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Transposed Matrix: ");
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write(array[j, i] + " ");
                }
                Console.WriteLine();
            }


            Console.Write("Main Diagonal Sum: ");
            int sum = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        sum += array[i, j];
                    }
                }
            }
            Console.WriteLine(sum);

            Console.Write("Secondary Diagonal Sum: ");
            sum = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                sum += array[i, size - 1 - i];
            }
            Console.WriteLine(sum);

        }
    }
}
