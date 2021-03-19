using System;

namespace selectiontask3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            int sum;

            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());

            sum = (num1+num2);

            if (sum == 10)
                Console.WriteLine("Sum of numbers is equal to 10");
            if (sum > 10)
                Console.WriteLine("Sum of numbers is greater than 10");
            if (sum < 10)
                Console.WriteLine ("Sum of numbers is lower than 10");

        }
    }
}
