using System;

namespace UserLogin
{
    public class LoginValidation
    {
        public delegate void ActionOnError(string errorMessage);

        private readonly ActionOnError actionOnError;

        private readonly string password;
        private readonly string username;
        private string error_message;

        public LoginValidation(string usernameI, string passwordI, ActionOnError actionOnErrorI)
        {
            username = usernameI;
            password = passwordI;
            actionOnError = actionOnErrorI;
        }

        public static UserRoles CurrentUserRole { get; private set; }

        public bool ValidateUserInput(out User userI)
        {
            if (username.Length < 5)
            {
                userI = null;
                actionOnError("The entered username is too short");
                return false;
            }

            if (password.Length < 5)
            {
                userI = null;
                actionOnError("The entered password is too short");
                return false;
            }

            userI = UserData.IsUserPassCorrect(username, password);
            if (userI == null)
            {
                actionOnError("No match found for this password/username combination.");
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