using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using CentareMVCAngular2.Models;

namespace CentareMVCAngular2.Repository
{
    public class UsersTools
    {
        public static List<Users> Collect()
        {
            List<Users> UsersInfo = new List<Users>();

            using (StreamReader sr = new StreamReader("users.csv"))
            {
                string line = sr.ReadLine();
                while (line != null)
                {
                    string[] userInfo = line.Split(',');
                    UsersInfo.Add(new Users(userInfo[0], userInfo[1], userInfo[2]/*, userInfo[3]*/));

                    line = sr.ReadLine();
                }
            }

            return UsersInfo;
        }
    }
}
