using ExamSystem.Entities.Abstract;

namespace ExamSystem.Entities.Concrete
{
    public class Section : IEntity
    {
        public int ID { get; set; }
        public int UnitID { get; set; }
        public string Name { get; set; }
        public int Number { get; set; }
    }
}