using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;




namespace CodingClub.Models
{
    public class StudentTeam
    {
        public int StudentTeamId { get; set; }//unique id 
        public int StudentId { get; set; }
        public int TeamId { get; set; }
        public Student Student { get; set; }// inherits from the Student table 

        public Team Team { get; set; } //Inherits from the Team table 


        //override statement will print out students first and last name and the team that they are associated with 
          
        public override string ToString() => $"{this.Student.StudentFName}{this.Student.StudentLName}{this.Team.TeamName}";
       
    }
}