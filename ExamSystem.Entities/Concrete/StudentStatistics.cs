using ExamSystem.Entities.Abstract;

namespace ExamSystem.Entities.Concrete
{
    public class StudentStatistics : IEntity
    {
        public int ID { get; set; }
        public int StudentID { get; set; }
        public int SectionID { get; set; }
        public int TrueCount { get; set; }
        public int FalseCount { get; set; }
    }
}