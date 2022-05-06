using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamSystem.Entities.Abstract;

namespace ExamSystem.Entities.Concrete
{
    public class Student : IEntity
    {
        public int ID { get; set; }
        public string UserID { get; set; }
        public int TimeIntervalID { get; set; }
    }
}
