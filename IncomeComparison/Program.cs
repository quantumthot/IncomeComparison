using System;

namespace IncomeComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonomous Income Comparison Program");

            Console.WriteLine("Person 1: What is your hourly rate?");
            int yourRate1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Person 1: Hours worked per week?");
            int yourHours1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Person 1, your annual salary is:");
            Console.WriteLine(yourRate1 * yourHours1 * 52);

            Console.WriteLine("Person 2: What is your hourly rate?");
            int yourRate2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Person 2: Hours worked per week?");
            int yourHours2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Person 2, your annual salary is:");
            Console.WriteLine(yourRate2 * yourHours2 * 52);

            Console.WriteLine("Does Person 1 make more money than Person 2? True or False?");
            string trueFalse = Console.ReadLine();// will store a string.
        }
    }
}
