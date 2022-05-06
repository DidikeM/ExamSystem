using ExamSystem.Entities.Abstract;

namespace ExamSystem.Entities.Concrete
{
    public class User : IEntity
    {
        public int ID { get; set; }
        public int UserTypeID { get; set; }
        public string Username { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string EMail { get; set; }
        public string Password { get; set; }
    }
}