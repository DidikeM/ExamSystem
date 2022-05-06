using System.Net.Mime;
using ExamSystem.Entities.Abstract;

namespace ExamSystem.Entities.Concrete
{
    public class Choice : IEntity
    {
        public int ID { get; set; }
        public int QuestionID { get; set; }
        public string Text { get; set; }
    }
}