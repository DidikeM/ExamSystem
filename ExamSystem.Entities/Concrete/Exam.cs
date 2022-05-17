using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamSystem.Entities.Abstract;

namespace ExamSystem.Entities.Concrete
{
    public class Exam : IEntity
    {
        public int ID { get; set; }
        public int ExaminerID { get; set; }
        public DateTime Duration { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
