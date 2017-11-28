using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityClasses
{
    public class Comment
    {
        public Comment() { }

        public int? Id { get; set; }
        public string CommentsDetails { get; set; }
        public string CommentsUserName { get; set; }
        public string CommentsTaskName{ get; set; }
        public string CommentsProjectName { get; set; }
        public DateTime CommentsDate { get; set; }
    }
}
