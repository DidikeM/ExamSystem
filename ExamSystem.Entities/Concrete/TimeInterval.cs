using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamSystem.Entities.Abstract;

namespace ExamSystem.Entities.Concrete
{
    public class TimeInterval : IEntity
    {
        public int ID { get; set; }
        public int Interval1 { get; set; }
        public int Interval2 { get; set; }
        public int Interval3 { get; set; }
        public int Interval4 { get; set; }
        public int Interval5 { get; set; }
        public int Interval6 { get; set; }
    }
}
