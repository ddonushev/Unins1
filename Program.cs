using System;

namespace UserLogin
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter a username: ");
            var usernameI = Console.ReadLine();
            Console.WriteLine("Please enter a password: ");
            var passwordI = Console.ReadLine();
            var loginValidation = new LoginValidation(usernameI, passwordI, message => Console.WriteLine(message));
            User blank_user = null;
            if (loginValidation.ValidateUserInput(out blank_user))
            {
                switch (blank_user.UserRole)
                {
                    case 1:
                        Console.WriteLine("You are logged in as an ADMIN.");
                        Console.WriteLine("You have the following options:");
                        Console.WriteLine("0: Exit");
                        Console.WriteLine("1: Change user role");
                        Console.WriteLine("2: Set user account expiration");
                        Console.WriteLine("3: See list of all users");
                        Console.WriteLine("4: Check activity log");

                        var adminOptionInput = Console.ReadLine();
                        switch (Convert.ToInt32(adminOptionInput))
                        {
                            case 0:
                                break;
                            case 1:
                                Console.WriteLine(
                                    "Please enter the username for the user whose role you want to change:");
                                var usernameRoleChange = Console.ReadLine();
                                Console.WriteLine("New role (int) should be:");
                                var newRole = Convert.ToInt32(Console.ReadLine());
                                //int casted to a UserRoles type for no reason
                                UserData.AssignUserRole(usernameRoleChange, (UserRoles) newRole);
                                break;
                            case 2:
                                Console.WriteLine(
                                    "Please enter the username for the account whose expiration date you want to change:");
                                var usernameExpirationChange = Console.ReadLine();
                                Console.WriteLine(
                                    "Please enter the date then account should expire on (01.01.2019 00:00:00):");
                                var expirationI = Console.ReadLine();
                                UserData.SetUserActiveTo(usernameExpirationChange, Convert.ToDateTime(expirationI));
                                break;
                            case 3:
                                Console.WriteLine(
                                    "List of all users: WIP WIP WIP");
                                break;
                            case 4:
                                Console.WriteLine(
                                    "Activity log:");
                                Logger.seeLog();
                                break;
                            case 5:
                                Console.WriteLine(
                                    "Current activities:");
                                Logger.GetCurrentSessionActivities();
                                break;
                            default:
                                Console.WriteLine("You did not choose a valid option.");
                                break;
                        }

                        break;
                    case 2:
                        Console.WriteLine("You are logged in as an Inspector.");
                        break;
                    case 3:
                        Console.WriteLine("You are logged in as a Professor.");
                        break;
                    case 4:
                        Console.WriteLine("You are logged in as a Student.");
                        break;
                    default:
                        Console.WriteLine("You are logged in as ANON.");
                        break;
                }

                Console.WriteLine(blank_user.Username);
                Console.WriteLine(blank_user.Password);
                Console.WriteLine(blank_user.FacNumber);
            }
        }
    }
}