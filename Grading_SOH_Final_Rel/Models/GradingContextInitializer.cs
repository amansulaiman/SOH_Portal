using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Grading_SOH_Final_Rel.Models
{
    public class GradingContextInitializer: DropCreateDatabaseAlways<GradingContext>
    {
        public override void InitializeDatabase(GradingContext context)
        {
            context.Departments.Add(new Department() { DepartmentName = "CSC" });
            context.Sessions.Add(new Session() { SessionName = "2016/2017" });

            
            var grade = new StudentsGrade()
            {
                Student = context.Students.Add(new Student()
                {
                    StudentID = "1001",
                    Age = 20,
                    Department = context.Departments.Add(new Department() { DepartmentName = "FRS" }),
                    FirstName = "Musa",
                    HighestQualification = "BSc",
                    LastName = "Sulaiman",
                    SurName = "Iliyasu",
                    Session = context.Sessions.Add(new Session() { SessionName = "2015/2016" }),
                    STATUS = "Current"
                })
            };


            context.StudentsGrades.Add(grade);
            
            

            base.InitializeDatabase(context);   
        }
    }
}