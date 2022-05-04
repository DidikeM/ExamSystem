using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSystem.Entities.Concrete
{
    public class ExamQuestions
    {
        public int ID { get; set; }
        public int QuestionID { get; set; }
        public int ExamID { get; set; }
    }
}
