namespace UserLogin
{
    public class User
    {
        private string username;
        private string password;
        private string facNumber;
        private int userRole;
        public User(string usernameI, string passwordI, string facNumberI, int userRoleI)
        {
            username = usernameI;
            password = passwordI;
            facNumber = facNumberI;
            userRole = userRoleI;
        }
    }
}