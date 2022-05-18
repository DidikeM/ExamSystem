using ExamSystem.Business.Abstract;
using ExamSystem.DataAccess.Abstract;
using ExamSystem.Entities.Concrete;

namespace ExamSystem.Business.Concrete
{
    public class TimeIntervalManager : ITimeIntervalService
    {
        private ITimeIntervalDal _timeIntervalDal;

        public TimeIntervalManager(ITimeIntervalDal timeIntervalDal)
        {
            _timeIntervalDal = timeIntervalDal;
        }

        public TimeInterval GetById(int id)
        {
            return _timeIntervalDal.Get(p => p.ID == id);
        }
    }
}