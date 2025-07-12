namespace Swap_Two_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter two numbers: ");
            int num1=int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"Numbers before swapping: {num1} , {num2}");
            SwapValues(ref num1, ref num2);
            Console.WriteLine($"Numbers after swapping: {num1} , {num2}");
        }
        static void SwapValues(ref int a, ref int b)
        {
            int temp = a;
            a=b; 
            b=temp;
        }
    }
}
