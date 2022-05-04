using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSystem.Entities.Concrete
{
    public class Exam
    {
        public int ID { get; set; }
        public int PreparedID { get; set; }
        public DateTime Duration { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
