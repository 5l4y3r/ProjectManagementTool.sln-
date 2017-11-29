using EntityClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class AddResourcePerson
    {
        public static void AddResource_Person(string s1, string s2, string s3)
        {
            var context = new PmtContext();

            context.ResourcePersons.Add(new ResourcePerson()
            {
                ResourcePersonName = s1,
                ResourcePersonProjectName = s2,
                ResourcePersonDesignation = s3
                
            });
            context.SaveChanges();
        }

    }
}
