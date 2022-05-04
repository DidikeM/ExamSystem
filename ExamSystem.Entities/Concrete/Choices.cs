using System.Net.Mime;

namespace ExamSystem.Entities.Concrete
{
    public class Choices
    {
        public int ID { get; set; }
        public int QuestionID { get; set; }
        public string Text { get; set; }
    }
}