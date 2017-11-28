using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityClasses
{
    public class Project
    {
        public Project() { }

        public int? Id { get; set; }
        public string ProjectName { get; set; }
        public string ProjectShortName { get; set; }
        public string ProjectDescription { get; set; }
        public DateTime ProjectPsd { get; set; }
        public DateTime ProjectPed { get; set; }
        public int ProjectDuration { get; set; }
        public string ProjectFilePath { get; set; }
        public bool ProjectStatus { get; set; }
        public string ProjectPriority { get; set; } 
        public string ProjectManager { get; set; }

    }
}

