namespace Modify_Array_Values_with_ref_and_out
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter size of array: ");
            int size = int.Parse(Console.ReadLine());
            int[] array = new int[size];
            Console.WriteLine("Enter Scores: ");
            int s = 0;
            for (int i = 0; i < size; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
                s += array[i];
            }
            Console.WriteLine($"The Sum of Array before modifying: {s}");
            ModifyAndSumArray(ref array, out int sum);
            Console.WriteLine($"The new Sum of Array after modifying: {sum}");
        }

        static void ModifyAndSumArray(ref int[] arr, out int sum)
        {
            sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] += 5;
                sum += arr[i];
            }
        }
    }
}
