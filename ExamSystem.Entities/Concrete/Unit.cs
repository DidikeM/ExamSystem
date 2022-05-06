using ExamSystem.Entities.Abstract;

namespace ExamSystem.Entities.Concrete
{
    public class Unit : IEntity
    {
        public int ID { get; set; }
        public int LectureID { get; set; }
        public string Name { get; set; }
        public int Number { get; set; }
    }
}