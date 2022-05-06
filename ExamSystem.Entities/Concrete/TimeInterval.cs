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
        public DateTime Interval1 { get; set; }
        public DateTime Interval2 { get; set; }
        public DateTime Interval3 { get; set; }
        public DateTime Interval4 { get; set; }
        public DateTime Interval5 { get; set; }
        public DateTime Interval6 { get; set; }
    }
}
