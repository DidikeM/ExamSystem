using System.Collections.Generic;
using ExamSystem.Business.Abstract;
using ExamSystem.DataAccess.Abstract;
using ExamSystem.Entities.Concrete;

namespace ExamSystem.Business.Concrete
{
    public class LectureManager:ILectureService
    {
        private ILectureDal _lectureDal;

        public LectureManager(ILectureDal lectureDal)
        {
            _lectureDal = lectureDal;
        }

        public List<Lecture> GetAll()
        {
            return _lectureDal.GetAll();
        }
    }
}