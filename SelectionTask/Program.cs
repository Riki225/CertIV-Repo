using System;

namespace selectiontask
{
    class Program
    {
        static void Main(string[] args)
        {
            string age;

            Console.WriteLine("Please Enter Your Age:");
            age = Console.ReadLine();
            int ageNum;
            ageNum = int.Parse(age);

            if(ageNum > 17)
                Console.WriteLine("Legally Adult Age.");
            else
            if(ageNum < 18)
                Console.WriteLine("Legally Not Adult Age.");
                
            }


        }
    }

