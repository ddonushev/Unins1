namespace UserLogin
{
    public class LoginValidation
    {
        public static UserRoles CurrentUserRole { get; private set; }

        public bool ValidateUserInput()
        {
            CurrentUserRole = UserRoles.Admin;
            return true;
        }
    }
}