using ExamSystem.Entities.Abstract;

namespace ExamSystem.Entities.Concrete
{
    public class Examiner : IEntity
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public bool ApprovalStatus { get; set; }
    }
}