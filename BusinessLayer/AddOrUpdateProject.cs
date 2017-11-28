using EntityClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{

    public class AddOrUpdateProject
    {
        public static void AddProject(string s1, string s2, string s3, string s4, string s5, DateTime s6, DateTime s7, int s8, string s9, string s10)
        {
            var context = new PmtContext();

            context.Projects.Add(new Project()
            {
                ProjectName = s1,
                ProjectShortName = s2,
                ProjectDescription =s3 ,
                ProjectManager = s4,
                ProjectFilePath = s5,
                ProjectPsd = s6,
                ProjectPed = s7,
                ProjectDuration =s8 ,
                ProjectPriority = s9,
                ProjectStatus = s10
            });
            context.SaveChanges();
        }
    }
}
