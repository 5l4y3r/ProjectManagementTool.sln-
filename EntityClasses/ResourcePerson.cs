using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityClasses
{
    public class ResourcePerson
    {
        public ResourcePerson() { }

        public int? Id { get; set; }
        public string ResourcePersonName { get; set; }
        public string ResourcePersonDesignation { get; set; }
        public string ResourcePersonProjectName { get; set; }
    }
}
