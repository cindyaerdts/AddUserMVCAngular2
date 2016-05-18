using System.Collections.Generic;
using System.DirectoryServices.AccountManagement;
using CentareMVCAngular2.Models;
using CentareMVCAngular2.Repository;

namespace CentareMVCAngular2.Controllers
{
    public class UserRepository
    {
        private readonly DataContext _context;

        public UserRepository(DataContext context)
        {
           this._context = context;
        }

        private PrincipalContext SampleOUContext;
        private PrincipalContext DomainContext;
        private UserPrincipal user1;

        public void CreateUsers()
        {
            //Collect users from file
            List<Users> UsersInfo = UsersTools.Collect();

            //Create context to Domain
            DomainContext = new PrincipalContext(
                ContextType.Domain);

            //Create context to Sample OU
            SampleOUContext = new PrincipalContext(
                ContextType.Domain,
                null,   //default domain
                "DC=SMDC,DC=NET");

            foreach (Users user in UsersInfo)
            {
                //Create user
                UserPrincipal newUser = new UserPrincipal(
                    SampleOUContext,
                    user.UserName,
                    "password",
                    true);

                newUser.GivenName = user.FirstName;
                newUser.Surname = user.LastName;
                newUser.UserPrincipalName = user.UserName + "@atos.net";

                //force user to change password
                newUser.ExpirePasswordNow();

                using (newUser)
                {
                    newUser.Save();
                }
            }
        }
    }
}