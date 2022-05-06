using ExamSystem.Entities.Abstract;

namespace ExamSystem.Entities.Concrete
{
    public class UserType : IEntity
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
}