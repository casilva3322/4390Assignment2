using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace CodingClub.Models
{
    public class ClientViewModel
    {
        public List<Client> Clients {get; set; }
        public List<Project> Projects {get; set;}

        public string clientList {get; set;}
        public string SearchString {get; set; }

        public Project Project { get; set; }
    }
}