using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CodingClub.Models
{
    public class DeployProject
    {
        public int DeployProjectId { get; set; }

        public int ProjectId { get; set; }
        public int ClientId { get; set; }

        public Client Client { get; set; } // inheriting from the Client table 

        public Project Project { get; set; } //inheriting from the Project table 

        
       
        //ToString Method will print out the Client First and Last name and the Project that it is associated with 
        public override string  ToString() => $"{this.Client.ClientFName}{this.Client.ClientLName}{this.Project.ProjectName}";
    }
}