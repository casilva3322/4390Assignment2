using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace CodingClub.Models
{
    public class SeedData
    {
        public static void Seed(IApplicationBuilder app)
        {
            var db = app.ApplicationServices.GetRequiredService<AppDbContext>();

            db.Database.EnsureCreated();

            if (!db.Clients.Any() && !db.Projects.Any() && !db.Students.Any() && !db.Teams.Any() && !db.DeployProjects.Any() && !db.StudentTeams.Any() )
            {   

                var clients = new List<Client>
                {
                    new Client
                    {
                    ClientId = 123,
                    ClientFName = "Jill",
                    ClientLName = "Hill",
                    ClientEmail = "jillHill@gmail.com"
                    },

                
                    new Client
                    {
                        ClientId = 456,
                        ClientFName = "Jesse",
                        ClientLName = "James",
                        ClientEmail = "jesseJamesAutoShop@yahoomail.com"
                    },

                    new Client
                    {
                        ClientId = 896,
                        ClientFName = "Sarah",
                        ClientLName = "Lee",
                        ClientEmail = "theBAkery@gmail.com"
                    }

                };

                var projects = new List<Project>
                {
                    new Project
                    {
                        ProjectId = 77,
                        ProjectName = "JillHillApp"
                    },
                    new Project
                    {
                        ProjectId = 88,
                        ProjectName = "JesseAutoApp"
                    },
                    new Project
                    {
                        ProjectId = 99,
                        ProjectName = "SarahsBakeryApp"
                    }
                };

                var students = new List<Student>
                {   
                   new Student
                   {
                        StudentId = 1234567,
                        StudentFName = "Jane",
                        StudentLName = "Doe",
                        StudentEmail = "janeDoe@buffs.wtamu.edu"
                   },
                    new Student
                    {
                        StudentId = 2345678,
                        StudentFName = "John",
                        StudentLName = "Green",
                        StudentEmail = "johnDoe@buffs.wtamu.edu"
                    },
                    new Student
                    {
                        StudentId = 3456789,
                        StudentFName = "Bob",
                        StudentLName = "Smith",
                        StudentEmail = "bobSmith@buffs.wtamu.edu"
                    },
                    new Student
                    {
                        StudentId = 5289637,
                        StudentFName = "Sally",
                        StudentLName = "Star",
                        StudentEmail = "sallyStar@buffs.wtamu.edu"
                    },
                    new Student
                    {
                        StudentId = 1424859,
                        StudentFName = "Carrie",
                        StudentLName = "Jones",
                        StudentEmail = "carrieJones@buffs.wtamu.edu"
                    },
                    new Student
                    {
                        StudentId = 9874587,
                        StudentFName = "Tim",
                        StudentLName = "Lee",
                        StudentEmail = "timLee@buffs.wtamu.edu"
                    }
                };
                var teams = new List<Team>
                {
                    new Team
                    {
                        TeamId = 19,
                        TeamName = "Blue"
                    },
                    new Team
                    {
                        TeamId = 16,
                        TeamName = "Green"
                    },
                    new Team
                    {
                        TeamId = 14,
                        TeamName = "Yellow"
                    }
                };
                var deployprojects = new List<DeployProject>
                {
                    new DeployProject{ProjectId = projects[0].ProjectId,
                                      Project = projects[0],
                                      ClientId = clients[0].ClientId,
                                      Client = clients[0]
                                      },
                    new DeployProject{ProjectId = projects[1].ProjectId,
                                      Project = projects[1],
                                      ClientId = clients[1].ClientId,
                                      Client = clients[1]
                                      },
                    new DeployProject{ProjectId = projects[2].ProjectId,
                                      Project = projects[2],
                                      ClientId = clients[2].ClientId,
                                      Client = clients[2]
                                      }
                };
                db.DeployProjects.AddRange(deployprojects);
                db.SaveChanges();
          
                var studentteams = new List<StudentTeam>
                {
                    new StudentTeam {StudentId = students[0].StudentId,
                                    Student = students[0],
                                    TeamId = teams[0].TeamId,
                                    Team = teams[0]
                                    },
                    new StudentTeam {StudentId = students[1].StudentId,
                                    Student = students[1],
                                    TeamId = teams[1].TeamId,
                                    Team = teams[1]
                                    },
                    new StudentTeam {StudentId = students[2].StudentId,
                                    Student = students[2],
                                    TeamId = teams[2].TeamId,
                                    Team = teams[2]
                                    }
                    
                };
                db.StudentTeams.AddRange(studentteams);
                db.SaveChanges();
            }
            else
                return;
        }
    }
}
