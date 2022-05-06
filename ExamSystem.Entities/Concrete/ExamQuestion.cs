using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamSystem.Entities.Abstract;

namespace ExamSystem.Entities.Concrete
{
    public class ExamQuestion : IEntity
    {
        public int ID { get; set; }
        public int QuestionID { get; set; }
        public int ExamID { get; set; }
    }
}
