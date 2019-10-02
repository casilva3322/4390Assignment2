using System;
using Microsoft.EntityFrameworkCore;

namespace CodingClub.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}

        public DbSet<Student> Students { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Team> Teams { get; set; }

        public DbSet<Project> Projects { get; set; }

        public DbSet<StudentTeam> StudentTeams { get; set; }

        public DbSet<DeployProject> DeployProjects { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().ToTable("Student");
            modelBuilder.Entity<Client>().ToTable("Client");
            modelBuilder.Entity<Team>().ToTable("Team");
            modelBuilder.Entity<Project>().ToTable("Project");

            modelBuilder.Entity<StudentTeam>()//join table 
            .HasKey(mc => new { mc.StudentId, mc.TeamId});

            modelBuilder.Entity<StudentTeam>()
            .HasOne(p => p.Team)
            .WithMany(pr => pr.Students)
            .HasForeignKey(id => id.TeamId);

            modelBuilder.Entity<StudentTeam>()
            .HasOne(pr => pr.Student)
            .WithMany(p => p.Teams)
            .HasForeignKey(id => id.StudentId); //assigning foreign key

            modelBuilder.Entity<DeployProject>()
            .HasKey(mc => new { mc.ProjectId, mc.ClientId});

            modelBuilder.Entity<DeployProject>()
            .HasOne(p => p.Client)
            .WithMany(pr => pr.Projects)
            .HasForeignKey(id => id.ClientId);

            modelBuilder.Entity<DeployProject>()
            .HasOne(pr => pr.Project)
            .WithMany (p => p.Clients)
            .HasForeignKey(id => id.ProjectId);
           
        }
    }
}