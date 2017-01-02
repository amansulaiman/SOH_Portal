namespace Grading_SOH_Final_Rel.Migrations
{
    using Grading_SOH_Final_Rel.Models;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Grading_SOH_Final_Rel.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Grading_SOH_Final_Rel.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            context.Departments.AddOrUpdate(d => d.DepartmentID,
                new Department() { DepartmentName = "CSC" });
            context.Sessions.AddOrUpdate(s => s.SessionID,
                new Session() { SessionName = "2016/2017" });

            context.Students.AddOrUpdate(st => st.StudentID,
                new Student()
                {
                    StudentID = "1001",
                    Age = 20,
                    Department = context.Departments.Find(1),
                    FirstName = "Musa",
                    HighestQualification = "BSc",
                    LastName = "Sulaiman",
                    SurName = "Iliyasu",
                    Session = context.Sessions.Find(1),
                    Status = "Current"
                });

            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));
            var UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));


            // In Startup iam creating first Admin Role and creating a default Admin User    
            if (!roleManager.RoleExists("Admin"))
            {
                // first we create Admin rool   
                var role = new IdentityRole();
                role.Name = "Admin";
                roleManager.Create(role);

            }

            // creating Creating AcademicUnit role    
            if (!roleManager.RoleExists("AcademicUnit"))
            {
                var role2 = new IdentityRole();
                role2.Name = "AcademicUnit";
                roleManager.Create(role2);

            }

            // creating Creating ExamaUnit role    
            if (!roleManager.RoleExists("ExamUnit"))
            {
                var role3 = new IdentityRole();
                role3.Name = "ExamUnit";
                roleManager.Create(role3);

            }

            // creating Creating DepartmentUnit role    
            if (!roleManager.RoleExists("DepartmentUnit"))
            {
                var role4 = new IdentityRole();
                role4.Name = "DepartmentUnit";
                roleManager.Create(role4);

            }

            // creating Creating Student role    
            if (!roleManager.RoleExists("Student"))
            {
                var role = new IdentityRole();
                role.Name = "Student";
                roleManager.Create(role);
            }

            // creating Creating Applicant role    
            if (!roleManager.RoleExists("Applicant"))
            {
                var role = new IdentityRole();
                role.Name = "Applicant";
                roleManager.Create(role);
            }

            //Check if the user existed
            if (!context.Users.Any(u => u.UserName == "amansulaiman92@gmail.com"))
            {
                var user = new ApplicationUser();
                user.UserName = "amansulaiman92@gmail.com";
                user.Email = "amansulaiman92@gmail.com";
                user.FullName = "Abdulrahman Sulaiman";
                user.PhoneNumber = "08148877252";

                string userPWD = "Aman@2016";

                var chkUser = UserManager.Create(user, userPWD);

                //Add Test User to All Roles for Test 
                if (chkUser.Succeeded)
                {
                    var result1 = UserManager.AddToRoles(user.Id, "Admin", "AcademicUnit", "ExamUnit", "DepartmentUnit");

                }
            }
            else
            {
                //If exist Add him to All Roles for Test 

                var uu = context.Users.Any(u => u.UserName == "amansulaiman92@gmai.com");

                var user = from p in context.Users
                            where p.UserName == "amansulaiman92@gmail.com"
                            select p;

                if (!UserManager.IsInRole(user.First().Id, "Admin"))
                {
                    UserManager.AddToRole(user.First().Id, "Admin");
                }

                if (!UserManager.IsInRole(user.First().Id, "AcademicUnit"))
                {
                    UserManager.AddToRole(user.First().Id, "AcademicUnit");
                }

                if (!UserManager.IsInRole(user.First().Id, "ExamUnit"))
                {
                    UserManager.AddToRole(user.First().Id, "ExamUnit");
                }

                if (!UserManager.IsInRole(user.First().Id, "DepartmentUnit"))
                {
                    UserManager.AddToRole(user.First().Id, "DepartmentUnit");
                }
            }
        }
    }
}
