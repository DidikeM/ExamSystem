using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSystem.Entities.Concrete
{
    public class Question
    {
        public int ID { get; set; }
        public int SectionID { get; set; }
        public int CorrectAnswer { get; set; }
        public string FilePath { get; set; }
        public int ChoiceFormatID { get; set; }
        public int ChoiceCount { get; set; }
        public string TableText { get; set; }
    }
}
