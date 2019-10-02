using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CodingClub.Models
{
    public  class Team 
    {
        public int TeamId { get; set; }

        [Display(Name = "Team Name")]
        public string TeamName { get; set; }

        public ICollection<StudentTeam> Students { get; set; }
        public override string ToString() => $"{this.TeamName}";

    }
}