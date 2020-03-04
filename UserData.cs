namespace UserLogin
{
    public static class UserData
    {
        private static User _defaultUser;

        public static User DefaultUser
        {
            get 
            { 
                DefaultUserData();
                return _defaultUser;
            }
            // ReSharper disable once ValueParameterNotUsed 
            // Public set not intended
            set { }
        }

        private static void DefaultUserData()
        {
            _defaultUser = new User("admin", "1234", "121216202", 1);
        }
    }
}