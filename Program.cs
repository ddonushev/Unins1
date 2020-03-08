using System;

namespace UserLogin
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var loginValidation = new LoginValidation();

            if (loginValidation.ValidateUserInput())
            {
                Console.WriteLine(UserData.TestUser.Username);
                Console.WriteLine(UserData.TestUser.Password);
                Console.WriteLine(UserData.TestUser.FacNumber);
                Console.WriteLine(LoginValidation.CurrentUserRole);
            }
        }
    }
}