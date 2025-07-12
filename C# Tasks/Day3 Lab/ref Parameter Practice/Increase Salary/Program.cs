namespace Increase_Salary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Eneter your current salary: ");
            int sal = int.Parse(Console.ReadLine());
            AddBonus(ref sal);
            Console.WriteLine($"Updated Salary: {sal}");
        }

        static void AddBonus(ref int salary)
        {
            int Bonus = 1000;
            salary = salary + Bonus;
        }
    }
}
