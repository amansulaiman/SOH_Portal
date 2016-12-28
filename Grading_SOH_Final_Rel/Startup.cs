using Grading_SOH_Final_Rel.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin;
using Owin;
using System;

[assembly: OwinStartupAttribute(typeof(Grading_SOH_Final_Rel.Startup))]
namespace Grading_SOH_Final_Rel
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);

            createRolesandUsers();
        }
        // In this method we will create default User roles and Admin user for login   
        private void createRolesandUsers()
        {
            ApplicationDbContext context = new ApplicationDbContext();

            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));
            var UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));


            // In Startup iam creating first Admin Role and creating a default Admin User    
            if (!roleManager.RoleExists("Admin"))
            {

                // first we create Admin rool   
                var role = new IdentityRole();
                role.Name = "Admin";
                roleManager.Create(role);

                //Here we create a Admin super user who will maintain the website                  

                var user = new ApplicationUser();
                user.UserName = "amansulaiman92@gmail.com";
                user.Email = "amansulaiman92@gmail.com";
                user.FullName = "Abdulrahman Sulaiman";
                user.PhoneNumber = "08148877252";

                string userPWD = "Aman@2016";

                var chkUser = UserManager.Create(user, userPWD);

                //Add default User to Role Admin   
                if (chkUser.Succeeded)
                {
                    var result1 = UserManager.AddToRole(user.Id, "Admin");

                }
            }

            // creating Creating AcademicUnit role    
            if (!roleManager.RoleExists("AcademicUnit"))
            {
                var role = new IdentityRole();
                role.Name = "AcademicUnit";
                roleManager.Create(role);

                //Here we create a user for test purofes                  

                var user = new ApplicationUser();
                user.UserName = "academic@gmail.com";
                user.Email = "academic@gmail.com";
                user.FullName = "Abdulrahman Sulaiman";
                user.PhoneNumber = "08148877252";

                string userPWD = "Aman@2016";

                var chkUser = UserManager.Create(user, userPWD);

                //Add User to Role AcademicUnit   
                if (chkUser.Succeeded)
                {
                    var result1 = UserManager.AddToRole(user.Id, "AcademicUnit");

                }
            }

            // creating Creating ExamaUnit role    
            if (!roleManager.RoleExists("ExamUnit"))
            {
                var role = new IdentityRole();
                role.Name = "ExamUnit";
                roleManager.Create(role);

                //Here we create a user for test purofes                  

                var user = new ApplicationUser();
                user.UserName = "exam@gmail.com";
                user.Email = "exam@gmail.com";
                user.FullName = "Abdulrahman Sulaiman";
                user.PhoneNumber = "08148877252";

                string userPWD = "Aman@2016";

                var chkUser = UserManager.Create(user, userPWD);

                //Add User to Role ExamaUnit   
                if (chkUser.Succeeded)
                {
                    var result1 = UserManager.AddToRole(user.Id, "ExamUnit");

                }

            }

            // creating Creating DepartmentUnit role    
            if (!roleManager.RoleExists("DepartmentUnit"))
            {
                var role = new IdentityRole();
                role.Name = "DepartmentUnit";
                roleManager.Create(role);

                //Here we create a user for test purofes                  

                var user = new ApplicationUser();
                user.UserName = "dept@gmail.com";
                user.Email = "dept@gmail.com";
                user.FullName = "Abdulrahman Sulaiman";
                user.PhoneNumber = "08148877252";

                string userPWD = "Aman@2016";

                var chkUser = UserManager.Create(user, userPWD);

                //Add User to Role DepartmentUnit   
                if (chkUser.Succeeded)
                {
                    var result1 = UserManager.AddToRole(user.Id, "DepartmentUnit");

                }
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
        }
    }
}
