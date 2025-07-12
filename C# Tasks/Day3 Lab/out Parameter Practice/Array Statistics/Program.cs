using System.Diagnostics.CodeAnalysis;
using System.Drawing;

namespace Array_Statistics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter size of array: ");
            int size = int.Parse(Console.ReadLine());
            int[] array = new int[size];
            Console.WriteLine("Enter Scores: ");
            for (int i = 0; i < size; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            CalculateArrayStats(array , out int max , out int min , out double avr );
            Console.WriteLine($"Max = {max}, Min = {min}, Average = {avr}");
        }
        static void CalculateArrayStats(int[] scores, out int max, out int min, out double average)
        {
            
            //MAx
            max = int.MinValue;
            for (int i = 0; i < scores.Length; i++)
            {
                if (scores[i] > max)
                {
                    max= scores[i];
                }
            }

            //Min
            min = int.MaxValue;
            for (int i = 0; i < scores.Length; i++)
            {
                if (scores[i] < min)
                {
                    min = scores[i];
                }
            }

            //Average
            int sum = 0;
            for (int i = 0; i < scores.Length; i++)
            {
                sum += scores[i];
            }
            average = sum / scores.Length;
        }
    }
}
