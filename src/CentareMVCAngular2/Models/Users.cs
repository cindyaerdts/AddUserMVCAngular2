using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CentareMVCAngular2.Models
{
    public class Users
    {
        public Users(string username, string firstname, string lastname/*, string mailAdress*/)
        {
            UserName = username;
            FirstName = firstname;
            LastName = lastname;
            //Mailadress = mailAdress;
        }

        public string UserName { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        //public string Mailadress { get; set; }
    }
}
