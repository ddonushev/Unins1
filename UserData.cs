namespace UserLogin
{
    public static class UserData
    {
        private static User _testUser;

        public static User TestUser
        {
            get
            {
                ResetTestUserData();
                return _testUser;
            }
            // ReSharper disable once ValueParameterNotUsed 
            // Public set not intended
            set { }
        }

        private static void ResetTestUserData()
        {
            if (_testUser == null) _testUser = new User("admin", "1234", "121216202", 1);
        }
    }
}