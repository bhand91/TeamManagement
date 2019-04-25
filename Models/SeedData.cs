using ContosoUniversity.Models;
using System;
using System.Linq;

namespace TeamManagement.Models
{
    public static class DbInitializer
    {
        public static void Initialize(TeamManagementContext context)
        {
            // context.Database.EnsureCreated();

            // Look for any students.
            if (context.Members.Any())
            {
                return;   // DB has been seeded
            }

            var members = new Member[]
            {
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
                new Member {FirstName = "Denise", LastName = "Rayford"},
            };
            foreach (Member m in members)
            {
                context.Members.Add(m);
            }
            context.SaveChanges();

            var courses = new Course[]
            {
            new Course{CourseID=1050,Title="Chemistry",Credits=3},
            new Course{CourseID=4022,Title="Microeconomics",Credits=3},
            new Course{CourseID=4041,Title="Macroeconomics",Credits=3},
            new Course{CourseID=1045,Title="Calculus",Credits=4},
            new Course{CourseID=3141,Title="Trigonometry",Credits=4},
            new Course{CourseID=2021,Title="Composition",Credits=3},
            new Course{CourseID=2042,Title="Literature",Credits=4}
            };
            foreach (Course c in courses)
            {
                context.Course.Add(c);
            }
            context.SaveChanges();

            var enrollments = new Enrollment[]
            {
            new Enrollment{StudentID=1,CourseID=1050,Grade=Grade.A},
            new Enrollment{StudentID=1,CourseID=4022,Grade=Grade.C},
            new Enrollment{StudentID=1,CourseID=4041,Grade=Grade.B},
            new Enrollment{StudentID=2,CourseID=1045,Grade=Grade.B},
            new Enrollment{StudentID=2,CourseID=3141,Grade=Grade.F},
            new Enrollment{StudentID=2,CourseID=2021,Grade=Grade.F},
            new Enrollment{StudentID=3,CourseID=1050},
            new Enrollment{StudentID=4,CourseID=1050},
            new Enrollment{StudentID=4,CourseID=4022,Grade=Grade.F},
            new Enrollment{StudentID=5,CourseID=4041,Grade=Grade.C},
            new Enrollment{StudentID=6,CourseID=1045},
            new Enrollment{StudentID=7,CourseID=3141,Grade=Grade.A},
            };
            foreach (Enrollment e in enrollments)
            {
                context.Enrollment.Add(e);
            }
            context.SaveChanges();
        }
    }
}