using Microsoft.EntityFrameworkCore;

namespace TeamManagement.Models
{
    public class TeamManagementContext : DbContext
    {
        public TeamManagementContext (DbContextOptions<TeamManagementContext> options)
            : base(options)
        {
        }

        public DbSet<TeamManagement.Models.Member> Members { get; set; }
        public DbSet<TeamManagement.Models.Task> Tasks {get; set;}

        public DbSet<TeamManagement.Models.TasksMembers> TasksMembers {get; set;}
    }
}