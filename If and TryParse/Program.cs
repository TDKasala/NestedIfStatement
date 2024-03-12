using System;

namespace YourNamespaceName
{
    class Program
    {
        static void Main(string[] args)
        {

            RegisterAndLogin();
            Console.Read();

        }

        public static void RegisterAndLogin()

        {
            Console.WriteLine("Create a username:");
            string username = Console.ReadLine();
            Console.WriteLine("Enter a password:");
            string password = Console.ReadLine();
            Console.WriteLine("You have been registered.");
            Console.WriteLine("-------------------------\n");

            string username1 = "";
            string password1 = "";

            Console.WriteLine("Enter your username to log in:");
            username1 = Console.ReadLine();

            

            if (username1.Equals(username)) 

            {
                Console.WriteLine("Enter your password:");
                password1 = Console.ReadLine();

                if (password1.Equals(password))
                {
                    Console.WriteLine("You have been logged in");
                }
                else 
                {
                    Console.WriteLine("Sorry wrong password,restart the program");
                }
            }

            else
            {
                Console.WriteLine("Wrong username, please restart the program");
            }

           

        }

    

    }
}
