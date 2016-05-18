using System.Configuration;
using CentareMVCAngular2.Models;
using Microsoft.Data.Entity;

namespace CentareMVCAngular2.Controllers
{
    public class DataContext: DbContext
    {
        public DbSet<Users> Users { get; set; }

        public static string ConnectionStringName
        {
            get
            {
                if (ConfigurationManager.AppSettings["ConnectionStringName"] != null)
                {
                    return ConfigurationManager.AppSettings["ConnectionStringName"].ToString();
                }
                return "DefaultConnection";
            }
        }
        //public DataContext()
        //        : base(nameOrConnectionString: DataContext.ConnectionStringName)
        //{
        //}
    }
}