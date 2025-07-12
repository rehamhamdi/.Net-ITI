namespace Get_Student_Info
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hello, Enter your name: ");
            String name = Console.ReadLine();
            GetStudentInfo(name, out int age, out double grade);
            Console.WriteLine($"age = {age}, grade = {grade}");
        }

        static void GetStudentInfo(string name, out int age, out double grade)
        {
            age = 20;
            grade = 85.5;
        }
    }
}
