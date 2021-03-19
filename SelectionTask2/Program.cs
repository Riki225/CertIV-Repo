using System;

namespace selectiontask2
{
    class Program
    {
        static void Main(string[] args)
        {
            string age;
            string gender;
            Console.WriteLine("Please Enter Your Gender (M/F):");
            gender = Console.ReadLine();

            Console.WriteLine("Please Enter Your Age:");
            age = Console.ReadLine();
            int ageNum;
            ageNum = int.Parse(age);

            if(ageNum > 17)
                Console.WriteLine(gender + " " + "is an adult.");
            else
            if(ageNum < 18)
                Console.WriteLine(gender + " " + "is not an adult.");
                
        }
    }
}
