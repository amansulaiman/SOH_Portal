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
                var role2 = new IdentityRole();
                role2.Name = "AcademicUnit";
                roleManager.Create(role2);

                //Here we create a user for test purofes                  

                var user2 = new ApplicationUser();
                user2.UserName = "academic@gmail.com";
                user2.Email = "academic@gmail.com";
                user2.FullName = "Abdulrahman Sulaiman";
                user2.PhoneNumber = "08148877252";

                string user2PWD = "Aman@2016";

                var chkUser2 = UserManager.Create(user2, user2PWD);

                //Add User to Role AcademicUnit   
                if (chkUser2.Succeeded)
                {
                    var result1 = UserManager.AddToRole(user2.Id, "AcademicUnit");

                }
            }

            // creating Creating ExamaUnit role    
            if (!roleManager.RoleExists("ExamUnit"))
            {
                var role3 = new IdentityRole();
                role3.Name = "ExamUnit";
                roleManager.Create(role3);

                //Here we create a user for test purofes                  

                var user3 = new ApplicationUser();
                user3.UserName = "exam@gmail.com";
                user3.Email = "exam@gmail.com";
                user3.FullName = "Abdulrahman Sulaiman";
                user3.PhoneNumber = "08148877252";

                string userPWD3 = "Aman@2016";

                var chkUser3 = UserManager.Create(user3, userPWD3);

                //Add User to Role ExamaUnit   
                if (chkUser3.Succeeded)
                {
                    var result1 = UserManager.AddToRole(user3.Id, "ExamUnit");

                }

            }

            // creating Creating DepartmentUnit role    
            if (!roleManager.RoleExists("DepartmentUnit"))
            {
                var role4 = new IdentityRole();
                role4.Name = "DepartmentUnit";
                roleManager.Create(role4);

                //Here we create a user for test purofes  

                var user4 = new ApplicationUser();
                user4.UserName = "dept@gmail.com";
                user4.Email = "dept@gmail.com";
                user4.FullName = "Abdulrahman Sulaiman";
                user4.PhoneNumber = "08148877252";

                string userPWD4 = "Aman@2016";

                var chkUser4 = UserManager.Create(user4, userPWD4);

                //Add User to Role DepartmentUnit   
                if (chkUser4.Succeeded)
                {
                    var result1 = UserManager.AddToRole(user4.Id, "DepartmentUnit");

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
