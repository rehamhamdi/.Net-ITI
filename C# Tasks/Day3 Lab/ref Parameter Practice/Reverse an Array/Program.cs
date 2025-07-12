namespace Reverse_an_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            Console.Write("Enter size of array: ");
            int size = int.Parse(Console.ReadLine());
            int[] array=new int [size];
            Console.WriteLine("Now enter the array elements: ");
            for (int i = 0; i < size; i++)
            {
                array[i]=int.Parse(Console.ReadLine());
            }

            ReverseArray(ref array);
            Console.Write("The Reversed Array: ");
            for (int i = 0; i < size; i++)
            {
                Console.Write(array[i] +" ");

            }

        }
        static void ReverseArray(ref int[] numbers)
        {
          Array.Reverse(numbers);
        }
    }
}
