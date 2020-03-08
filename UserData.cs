namespace UserLogin
{
    public static class UserData
    {
        private static readonly User[] _testUsers =
        {
            new User("default_admin", "1234", "121216202", 1),
            new User("student1", "123456", "121216202", 4),
            new User("student2", "1234567", "121216202", 4)
        };

        public static User[] TestUsers
        {
            get
            {
                ResetTestUserData();
                return _testUsers;
            }
            // ReSharper disable once ValueParameterNotUsed 
            // Public set not intended
            set { }
        }

        private static void ResetTestUserData()
        {
            //Ne jelaem takuv metod veche
        }

        public static User IsUserPassCorrect(string usernameI, string passwordI)
        {
            for (var i = 0; i < _testUsers.Length; i++)
                if (usernameI.Equals(_testUsers[i].Username) && passwordI.Equals(_testUsers[i].Password))
                    return _testUsers[i];
            //Default return value.
            return null;
        }
    }
}