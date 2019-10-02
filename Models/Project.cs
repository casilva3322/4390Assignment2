using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CodingClub.Models
{
    public  class Project
    {
        public int ProjectId { get; set; }

        [Display(Name = "Project Name")]
        public string ProjectName { get; set; }

        public ICollection<DeployProject> Clients { get; set; }
        public ICollection<Student> Students { get; set;}
        public override string ToString() => $"{ this.ProjectName}";
    }
}