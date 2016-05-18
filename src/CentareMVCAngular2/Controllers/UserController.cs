using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.DirectoryServices.AccountManagement;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;

namespace CentareMVCAngular2.Controllers
{
    
    public class UserController : Controller
    {
        //private readonly UserRepository _user;
        //public UserController(UserRepository user)
        //{
        //    this._user = user;
        //}
        private PrincipalContext DomainContext;
        private UserPrincipal user1;

        [Route("user/{userName}")]
        [HttpGet]
        public void FindUser(string userName)
        {

            try
            {
                //On real server, query List posible IP-adresses/ 
                //check wich IP-adress reacts 1st. 
                DomainContext = new PrincipalContext(
                    ContextType.Domain,
                    null,   //default domain
                    "192.168.1.102");

                user1 = UserPrincipal.FindByIdentity(
                DomainContext,
                userName);
            }
            catch (Exception errorMessage) 
            {
                Debug.WriteLine("Couldn't connect to Atos domain. ErrorMessage:" + errorMessage);
            }



        }
    }
}
