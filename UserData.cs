using System;

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
            foreach (var user in _testUsers)
            {
                user.Created = DateTime.Now;
                user.Expires = DateTime.MaxValue;
            }
        }

        public static User IsUserPassCorrect(string usernameI, string passwordI)
        {
            foreach (var testUser in _testUsers)
                if (usernameI.Equals(testUser.Username) && passwordI.Equals(testUser.Password))
                    return testUser;
            //Default return value.
            return null;
        }

        public static void SetUserActiveTo(string usernameI, DateTime expiresI)
        {
            foreach (var user in _testUsers)
                if (user.Username.Equals(usernameI))
                    user.Expires = expiresI;
        }

        public static void AssignUserRole(string usernameI, UserRoles roleI)
        {
            foreach (var user in _testUsers)
                if (user.Username.Equals(usernameI))
                    //UserRoles - Enum - casted to int 
                    user.UserRole = (int) roleI;
        }
    }
}