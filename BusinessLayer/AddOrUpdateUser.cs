using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityClasses;

namespace BusinessLayer
{
    public class AddOrUpdateUser
    {
        public static void AddUser(string s1, string s2, string s3, bool s4, string s5)
        {
            var context = new PmtContext();

            context.Users.Add(new User()
            {
                UserName = s1,
                UserEmail = s2,
                UserPassword = s3,
                UserStatus = s4,
                UserDesignation = s5
            });
            context.SaveChanges();
        }
    }
}
