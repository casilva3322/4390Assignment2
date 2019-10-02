using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CodingClub.Models
{
    public class Client
    {
        public int ClientId { get; set; }
         // 
        [Display(Name = "First Name")] 
        public string ClientFName { get; set; }

        [Display(Name = "Last Name ")]
        public string ClientLName { get; set; }

        [Display(Name = " Email")]
        public string ClientEmail { get; set; }
        public ICollection<DeployProject> Projects { get; set; }

        public ICollection<Client> clients { get; set; }

        public override string ToString() => $"{this.ClientFName}{this.ClientLName}";

      

      
    }
}