using System;

namespace UserLogin
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter a username: ");
            var usernameI = Console.ReadLine();
            Console.WriteLine("Please enter a password: ");
            var passwordI = Console.ReadLine();
            var loginValidation = new LoginValidation(usernameI, passwordI);
            User blank_user = null;
            if (loginValidation.ValidateUserInput(out blank_user))
            {
                Console.WriteLine(blank_user.Username);
                Console.WriteLine(blank_user.Password);
                Console.WriteLine(blank_user.FacNumber);
                Console.WriteLine(blank_user.UserRole);
            }
        }
    }
}