using System.Data.Entity;
using ExamSystem.Entities.Concrete;

namespace ExamSystem.DataAccess.Concrete.EntityFramework
{
    public class ExamSystemContext : DbContext
    {
        public DbSet<Choice> Choices { get; set; }
        public DbSet<ChoiceFormat> ChoiceFormats { get; set; }
        public DbSet<Exam> Exams { get; set; }
        public DbSet<ExamQuestion> ExamQuestions { get; set; }
        public DbSet<Lecture> Lectures { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Section> Sections { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<StudentStatus> StudentStatus { get; set; }
        public DbSet<TimeInterval> TimeIntervals { get; set; }
        public DbSet<Unit> Units { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserType> UserTypes { get; set; }

    }
}