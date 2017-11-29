using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityClasses;

namespace BusinessLayer
{
    public class AddOrUpdateTask
    {
        public static void AddTask(string s1, string s2, string s3,DateTime s4, string s5)
        {
            var context = new PmtContext();

            context.Tasks.Add(new EntityClasses.Task()
            {
                TasksName = s3,
                TasksProjectName = s1,
                TasksAssignedUser = s2,
                dueDate = s4,
                priority = s5
                
            });
            context.SaveChanges();
        }
    }
}
