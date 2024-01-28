/* Author: Matthew Hudson
 * Course: COMP-003A-L01
 * Purpose: Code for Assignment 2
 */
namespace COMP003AL01.Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "COMP-003A - Assignment 2";
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("****************************************");
            Console.WriteLine("Console Section");
            Console.WriteLine("****************************************");
            Console.WriteLine("\n");
            Console.WriteLine("****************************************");
            Console.WriteLine("String Section");
            Console.WriteLine("****************************************");
            Console.Write("Enter First Name: ");
            string firstName = Console.ReadLine();
            Console.Write("Enter Middle Name: ");
            string MiddleName = Console.ReadLine();
            Console.Write("Enter Last Name: ");
            string LastName = Console.ReadLine();
            Console.Write("Enter Age in 2023: ");
            string inputAge = Console.ReadLine();
            int yearBorn = 2024 - Convert.ToInt32(inputAge);
            Console.WriteLine($"Hello, {firstName} {MiddleName} {LastName}. You were born in {yearBorn}.");
            Console.WriteLine("\n");
            Console.WriteLine("****************************************");
            Console.WriteLine("Math Section");
            Console.WriteLine("****************************************");
            int integer1, integer2, result;
            Console.Write("Enter an integer for integer1: ");
            integer1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter an integer for integer2: ");
            integer2 = Convert.ToInt32(Console.ReadLine());
            Console.Write($"{integer1} + {integer2} = {integer1 + integer2}");
            Console.WriteLine("\n");
            Console.Write($"{integer1} - {integer2} = {integer1 - integer2}");
            Console.WriteLine("\n");
            Console.Write($"{integer1} * {integer2} = {integer1 * integer2}");
            Console.WriteLine("\n");
            Console.Write($"{integer1} / {integer2} = {integer1 / integer2}");
            Console.WriteLine("\n");
            Console.Write($"{integer1} % {integer2} = {integer1 % integer2}");







        }
    }
}
