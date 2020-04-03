using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace UserLogin
{
    public static class Logger
    {
        private static readonly List<string> currentSessionActivities = new List<string>();

        public static void LogActivity(string activity)
        {
            var activityLine = DateTime.Now + ";"
                                            + LoginValidation.currentUserUsername + ";"
                                            + LoginValidation.CurrentUserRole + ";"
                                            + activity;
            currentSessionActivities.Add(activityLine);
            //Relative path from content root does not appear to work. Absolute path is used. TODO: Fix this so it works with a relative path 
            if (File.Exists("C:\\Users\\Dimitar\\RiderProjects\\UserLogin\\test.txt"))
            {
                Console.WriteLine("test.txt was found");
                File.AppendAllText("C:\\Users\\Dimitar\\RiderProjects\\UserLogin\\test.txt", activityLine);
            }
            else
            {
                Console.WriteLine("test.txt not found");
            }
        }

        public static void seeLog()
        {
            var sr = new StreamReader("C:\\Users\\Dimitar\\RiderProjects\\UserLogin\\test.txt");
            var Sb = new StringBuilder();
            Sb.Append(sr.ReadToEnd());
            Console.WriteLine(Sb.ToString());
            sr.Close();
        }

        public static void GetCurrentSessionActivities()
        {
            var Sb = new StringBuilder();
            foreach (var line in currentSessionActivities) Sb.Append(line);
            Console.WriteLine(Sb.ToString());
        }
    }
}