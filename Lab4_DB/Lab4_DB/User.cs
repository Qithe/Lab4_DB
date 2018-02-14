using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_DB
{
    public class UserClass
    {
        public UserClass(string email, string image)
        {
            this.UserClassEmail = email;
            this.UserClassImageAddress = image;
        }

        public int UserClassId { get; set; }
        public string UserClassEmail { get; set; }
        public string UserClassImageAddress { get; set; }
        public bool UserClassImageVerified { get; set; }
    }
    public class UserContex : DbContext
    {
        private const string cs = "test"; //Contectionstring sätts här
        public UserContex() : base(cs) { }
        public DbSet<UserClass> UserClasses { get; set; }
    }
}
