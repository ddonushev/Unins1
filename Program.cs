using System;

namespace UserLogin
{
    class Program
    {
        static void Main(string[] args)
        {
            LoginValidation loginValidation = new LoginValidation();

            if (loginValidation.ValidateUserInput())
            {
                //izvejdane danni
                Console.WriteLine(UserData.DefaultUser);
            }
        }
    }
}