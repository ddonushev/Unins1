using System;

namespace UserLogin
{
    public class LoginValidation
    {
        private readonly string password;
        private readonly string username;
        private string error_message;

        public LoginValidation(string usernameI, string passwordI)
        {
            username = usernameI;
            password = passwordI;
        }

        public static UserRoles CurrentUserRole { get; private set; }

        public bool ValidateUserInput(out User userI)
        {
            if (username.Length < 5)
            {
                userI = null;
                error_message = "The entered username is too short";
                return false;
            }

            if (password.Length < 5)
            {
                userI = null;
                error_message = "The entered password is too short";
                return false;
            }

            userI = UserData.IsUserPassCorrect(username, password);
            if (userI == null)
            {
                error_message = "No match found for this password/username combination.";
                CurrentUserRole = UserRoles.Anonymous;
                return false;
            }

            CurrentUserRole = (UserRoles) userI.UserRole;
            error_message = "Login successful.";
            Console.WriteLine(error_message);
            return true;
        }
    }
}