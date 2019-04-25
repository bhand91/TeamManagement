using TeamManagement.Models;
using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace TeamManagement.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using(var context = new TeamManagementContext(
                serviceProvider.GetRequiredService<
                DbContextOptions<TeamManagementContext>>()))
            {
            // context.Database.EnsureCreated();

            // Look for any Members
                if (context.Members.Any())
                {
                    return;   // DB has been seeded
                }

                context.Members.AddRange(
                
                    new Member {FirstName = "Joe", LastName = "Blow"},
                    new Member {FirstName = "Dawn", LastName = "Spring"},
                    new Member {FirstName = "Donald", LastName = "Draper"},
                    new Member {FirstName = "Kashion", LastName = "Smith"},
                    new Member {FirstName = "Braley", LastName = "Hand"},
                    new Member {FirstName = "Hope", LastName = "Stokes"},
                    new Member {FirstName = "Dan", LastName = "Quant"},
                    new Member {FirstName = "Mary", LastName = "Ramirez"},
                    new Member {FirstName = "Stephanie", LastName = "Andrews"},
                    new Member {FirstName = "Peggy", LastName = "Olson"},
                    new Member {FirstName = "Gary", LastName = "Mulberg"},
                    new Member {FirstName = "Sallye", LastName = "Hand"},
                    new Member {FirstName = "Gavin", LastName = "Beck"},
                    new Member {FirstName = "Kim", LastName = "McGill"},
                    new Member {FirstName = "Hollie", LastName = "Hawkins"},
                    new Member {FirstName = "Roger", LastName = "Sterling"},
                    new Member {FirstName = "Charles", LastName = "Ritchie"},
                    new Member {FirstName = "Bobby", LastName = "Lee"},
                    new Member {FirstName = "Denise", LastName = "Rayford"}
                );
                context.SaveChanges();


                context.Tasks.AddRange(
                    new Task{TaskName= "2019 Golden Nail Awards", DueDate = DateTime.Parse("2019-04-18"), TaskDec = "The 2019 Golden Nail Awards honoring art supporters in the Texas Panhandle will be held on April 25th at the Derrick Event Center in Downtown Amarillo."},
                    new Task{TaskName= "CIDM 4372 Group Project", DueDate = DateTime.Parse("2019-02-22"), TaskDec = "This project requires 6 task members to clean, analyze, and present data from a file."},
                    new Task{TaskName= "Present 2022 TTIA Bid", DueDate = DateTime.Parse("2019-06-01"), TaskDec = "Sales team needs to work to gather requirements for the conference and get offers from partners."},
                    new Task{TaskName= "Task 2", DueDate = DateTime.Parse("2018-07-06"), TaskDec = "This is task 2"},
                    new Task{TaskName= "Task 3", DueDate = DateTime.Parse("2020-10-05"), TaskDec = "This is task 3"},
                    new Task{TaskName= "Task 4", DueDate = DateTime.Parse("2019-06-05"), TaskDec = "This is task 4"},
                    new Task{TaskName= "Task 5", DueDate = DateTime.Parse("2018-10-15"), TaskDec = "This is task 5"},
                    new Task{TaskName= "Task 6", DueDate = DateTime.Parse("2019-05-05"), TaskDec = "This is task 6"},
                    new Task{TaskName= "Task 7", DueDate = DateTime.Parse("2019-11-19"), TaskDec = "This is task 7"},
                    new Task{TaskName= "Task 8", DueDate = DateTime.Parse("2019-12-20"), TaskDec = "This is task 8"},
                    new Task{TaskName= "Task 9", DueDate = DateTime.Parse("2019-09-08"), TaskDec = "This is task 9"},
                    new Task{TaskName= "Task 10", DueDate = DateTime.Parse("2019-01-22"), TaskDec = "This is task 10"},
                    new Task{TaskName= "Task 11", DueDate = DateTime.Parse("2020-02-13"), TaskDec = "This is task 11"},
                    new Task{TaskName= "Task 12", DueDate = DateTime.Parse("2020-03-15"), TaskDec = "This is task 12"},
                    new Task{TaskName= "Task 13", DueDate = DateTime.Parse("2021-04-18"), TaskDec = "This is task 13"},
                    new Task{TaskName= "Task 14", DueDate = DateTime.Parse("2019-05-25"), TaskDec = "This is task 14"},
                    new Task{TaskName= "Task 15", DueDate = DateTime.Parse("2019-10-13"), TaskDec = "This is task 15"},
                    new Task{TaskName= "Task 16", DueDate = DateTime.Parse("2023-01-01"), TaskDec = "This is task 16"},
                    new Task{TaskName= "Task 17", DueDate = DateTime.Parse("2050-01-01"), TaskDec = "This is task 17"}
                );

                context.SaveChanges();

                context.TasksMembers.AddRange(
                    new TasksMembers{TaskID = 1, MemberID = 1, MemberRole = Role.Manager, AssignmentDes = "Define roles for other team members and head planning meetings" },
                    new TasksMembers{TaskID = 1, MemberID = 2, MemberRole = Role.Researcher, AssignmentDes = "Send out RFPs and present to team" },
                    new TasksMembers{TaskID = 1, MemberID = 3, MemberRole = Role.Specialist, AssignmentDes = "Keep track of and create budget for event." },
                    new TasksMembers{TaskID = 1, MemberID = 4, MemberRole = Role.Task_Worker, AssignmentDes = "Assignment Description" },
                    new TasksMembers{TaskID = 2, MemberID = 5, MemberRole = Role.Manager, AssignmentDes = "Assignment Description" },
                    new TasksMembers{TaskID = 2, MemberID = 6, MemberRole = Role.Task_Worker, AssignmentDes = "Assignment Description" },
                    new TasksMembers{TaskID = 2, MemberID = 2, MemberRole = Role.Task_Worker, AssignmentDes = "Assignment Description" },
                    new TasksMembers{TaskID = 2, MemberID = 1, MemberRole = Role.Task_Worker, AssignmentDes = "Assignment Description" },
                    new TasksMembers{TaskID = 2, MemberID = 7, MemberRole = Role.Task_Worker, AssignmentDes = "Assignment Description" },
                    new TasksMembers{TaskID = 2, MemberID = 8, MemberRole = Role.Task_Worker, AssignmentDes = "Assignment Description" },
                    new TasksMembers{TaskID = 3, MemberID = 9, MemberRole = Role.Manager, AssignmentDes = "Presents bid to TTIA board" },
                    new TasksMembers{TaskID = 3, MemberID = 10, MemberRole = Role.Specialist, AssignmentDes = "Ensures that all servicing promises are met" },
                    new TasksMembers{TaskID = 3, MemberID = 11, MemberRole = Role.Researcher, AssignmentDes = "Gather requirements for conference and send out RFPs" },
                    new TasksMembers{TaskID = 7, MemberID = 12, MemberRole = Role.Task_Worker, AssignmentDes = "Assignment Description" },
                    new TasksMembers{TaskID = 7, MemberID = 19, MemberRole = Role.Task_Worker, AssignmentDes = "Assignment Description" },
                    new TasksMembers{TaskID = 5, MemberID = 8, MemberRole = Role.Task_Worker, AssignmentDes = "Assignment Description" },
                    new TasksMembers{TaskID = 4, MemberID = 9, MemberRole = Role.Manager, AssignmentDes = "Assignment Description" },
                    new TasksMembers{TaskID = 6, MemberID = 2, MemberRole = Role.Specialist, AssignmentDes = "Assignment Description" },
                    new TasksMembers{TaskID = 18, MemberID = 9, MemberRole = Role.Researcher, AssignmentDes = "Assignment Description" },
                    new TasksMembers{TaskID = 19, MemberID = 11, MemberRole = Role.Researcher, AssignmentDes = "Assignment Description" },
                    new TasksMembers{TaskID = 12, MemberID = 13, MemberRole = Role.Specialist, AssignmentDes = "Assignment Description" },
                    new TasksMembers{TaskID = 12, MemberID = 13, MemberRole = Role.Task_Worker, AssignmentDes = "" },
                    new TasksMembers{TaskID = 12, MemberID = 4, MemberRole = Role.Task_Worker, AssignmentDes = "" },
                    new TasksMembers{TaskID = 15, MemberID = 5, MemberRole = Role.Manager, AssignmentDes = "" },
                    new TasksMembers{TaskID = 15, MemberID = 6, MemberRole = Role.Task_Worker, AssignmentDes = "" },
                    new TasksMembers{TaskID = 11, MemberID = 7, MemberRole = Role.Specialist, AssignmentDes = "" },
                    new TasksMembers{TaskID = 11, MemberID = 8, MemberRole = Role.Researcher, AssignmentDes = "" },
                    new TasksMembers{TaskID = 11, MemberID = 1, MemberRole = Role.Manager, AssignmentDes = "" }

                );

                context.SaveChanges();
            }
        }
    }
}