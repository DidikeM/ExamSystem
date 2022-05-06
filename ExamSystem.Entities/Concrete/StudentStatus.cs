using System;
using ExamSystem.Entities.Abstract;

namespace ExamSystem.Entities.Concrete
{
    public class StudentStatus : IEntity
    {
        public int ID { get; set; }
        public int StudentID { get; set; }
        public int QuestionID { get; set; }
        public DateTime FirstTime { get; set; }
        public int Status { get; set; }
    }
}