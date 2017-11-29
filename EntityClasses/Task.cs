using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityClasses
{
    public class Task
    {
        public Task() { }
        
        public int? Id { get; set; }
        public string TasksName { get; set; }
        public string TasksProjectName { get; set; }
        public string TasksAssignedUser { get; set; }
        public DateTime dueDate { get; set; }
        public string priority { get; set; }
    }
}
