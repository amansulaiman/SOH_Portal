namespace Grading_SOH_Final_Rel.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class GradingContext : DbContext
    {
        public GradingContext()
            : base("name=GradingModelDB")
        {
        }

        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Semister> Semisters { get; set; }
        public virtual DbSet<Session> Sessions { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<StudentsGrade> StudentsGrades { get; set; }
        public virtual DbSet<Applicants> Applicants { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>()
                .HasMany(e => e.StudentsGrades)
                .WithOptional(e => e.Course)
                .HasForeignKey(e => e.C1Code);

            modelBuilder.Entity<Course>()
                .HasMany(e => e.StudentsGrades1)
                .WithOptional(e => e.Course1)
                .HasForeignKey(e => e.C2Code);

            modelBuilder.Entity<Course>()
                .HasMany(e => e.StudentsGrades2)
                .WithOptional(e => e.Course2)
                .HasForeignKey(e => e.C3Code);

            modelBuilder.Entity<Course>()
                .HasMany(e => e.StudentsGrades3)
                .WithOptional(e => e.Course3)
                .HasForeignKey(e => e.C4Code);

            modelBuilder.Entity<Course>()
                .HasMany(e => e.StudentsGrades4)
                .WithOptional(e => e.Course4)
                .HasForeignKey(e => e.C5Code);

            modelBuilder.Entity<Course>()
                .HasMany(e => e.StudentsGrades5)
                .WithOptional(e => e.Course5)
                .HasForeignKey(e => e.C6Code);

            modelBuilder.Entity<Course>()
                .HasMany(e => e.StudentsGrades6)
                .WithOptional(e => e.Course6)
                .HasForeignKey(e => e.C7Code);

            modelBuilder.Entity<Course>()
                .HasMany(e => e.StudentsGrades7)
                .WithOptional(e => e.Course7)
                .HasForeignKey(e => e.C8Code);

            modelBuilder.Entity<Department>()
                .HasMany(e => e.Courses)
                .WithRequired(e => e.Department)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Department>()
                .HasMany(e => e.Students)
                .WithRequired(e => e.Department)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Semister>()
                .HasMany(e => e.Courses)
                .WithRequired(e => e.Semister)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Session>()
                .HasMany(e => e.Semisters)
                .WithRequired(e => e.Session)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Session>()
                .HasMany(e => e.Students)
                .WithRequired(e => e.Session)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Student>()
                .HasOptional(e => e.StudentsGrade)
                .WithRequired(e => e.Student);
        }
    }
}
