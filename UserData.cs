using System;
using System.Collections.Generic;

namespace UserLogin
{
    public static class UserData
    {
        private static List<User> _testUsers;

        public static List<User> TestUser
        {
            get
            {
                ResetTestUserData();
                return _testUsers;
            }
            set { }
        }

        private static void ResetTestUserData()
        {
            // if (_testUsers == null)
            // {
            _testUsers = new List<User>();
            var user1 = new User("default_admin", "12345678", "121216202", 1);
            var user2 = new User("student1", "123456", "121216202", 4);
            var user3 = new User("student2", "1234567", "121216202", 4);
            _testUsers.Add(user1);
            _testUsers.Add(user2);
            _testUsers.Add(user3);
            // }
        }

        public static User IsUserPassCorrect(string usernameI, string passwordI)
        {
            foreach (var testUser in TestUser)
                if (usernameI.Equals(testUser.Username) && passwordI.Equals(testUser.Password))
                    return testUser;
            //Default return value.
            return null;
        }

        public static void SetUserActiveTo(string usernameI, DateTime expiresI)
        {
            foreach (var user in TestUser)
                if (user.Username.Equals(usernameI))
                {
                    user.Expires = expiresI;
                    Logger.LogActivity("Account expiration changed for " + user.Username);
                }
        }

        public static void AssignUserRole(string usernameI, UserRoles roleI)
        {
            foreach (var user in TestUser)
                if (user.Username.Equals(usernameI))
                {
                    //UserRoles - Enum - casted to int a
                    user.UserRole = (int) roleI;
                    Logger.LogActivity("Account role changed for " + user.Username);
                }
        }
    }
}