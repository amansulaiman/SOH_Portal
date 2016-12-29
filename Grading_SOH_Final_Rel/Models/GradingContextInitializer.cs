using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Grading_SOH_Final_Rel.Models
{
    public class GradingContextInitializer: DropCreateDatabaseAlways<PortalContext>
    {
        public override void InitializeDatabase(PortalContext context)
        {
            var Depat = context.Departments.Add(new Department() { DepartmentName = "Health Education" });
            context.Sessions.Add(new Session() { SessionName = "2016/2017" });



            context.Students.Add(new Student()
            {
                StudentID = "1001",
                Age = 20,
                Department = context.Departments.Add(new Department() { DepartmentName = "FRS" }),
                FirstName = "Musa",
                HighestQualification = "BSc",
                LastName = "Sulaiman",
                SurName = "Iliyasu",
                Session = context.Sessions.Add(new Session() { SessionName = "2015/2016" }),
                Status = "Current"
            });
            base.InitializeDatabase(context);   
        }
    }
}