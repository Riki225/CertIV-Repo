using System;

namespace selectiontaskex2
{
    class Program
    {
        static void Main(string[] args)
        {
            string username;
            string password;
            string exusername;
            exusername = "rikichoi";
            string expassword;
            expassword = "swinburne469";
            int userstatus;
            int passstatus;
            userstatus = 0;
            passstatus= 0;


            Console.WriteLine("Please Enter Your Username:");
            username = Console.ReadLine();
            Console.WriteLine("Please Enter Your Password:");
            password = Console.ReadLine();

            if (username == exusername) 
                userstatus = 1;
            if (userstatus == 0)
            goto UserFail;
            
            if (password == expassword) 
                passstatus = 1;
            if (passstatus == 0)
            goto UserFail;
            
            else 
                if (passstatus == 1 & userstatus == 1)
            Console.WriteLine("Login Successful");
            return;
            
            UserFail:
            Console.WriteLine("Login Unsuccessful");
            



        }
    }
}
