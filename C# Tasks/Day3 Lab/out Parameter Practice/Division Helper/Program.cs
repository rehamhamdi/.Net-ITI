namespace Division_Helper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter Two Integers: ");
            int dividend = int.Parse(Console.ReadLine());
            int divisor = int.Parse(Console.ReadLine());
            DivideAndRemainder(dividend,divisor, out int q , out int r);
            Console.WriteLine($"The quotient is= {q}");
            Console.WriteLine($"The remainder is= {r}");
        }

        static void DivideAndRemainder(int dividend, int divisor, out int quotient, out int remainder)
        {
            quotient =dividend / divisor;
            remainder = dividend % divisor;

        }
    }
}
