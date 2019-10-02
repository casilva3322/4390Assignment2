using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CodingClub.Models
{
    //declaring abstract class for sharing 

    public  class Student
    {
        public int StudentId { get; set; }

        [Display(Name = "First Name")]
        public string StudentFName { get; set; }
       
        [Display(Name = "Last Name")]
        public string StudentLName { get; set; }

        [Display(Name = "Email ")]
        public string StudentEmail { get; set; }

        public ICollection<StudentTeam> Teams { get; set; }
        
       //ToString method prints out Students first and last name
        public override string ToString() => $"{this.StudentFName}{this.StudentLName}";



    }
}