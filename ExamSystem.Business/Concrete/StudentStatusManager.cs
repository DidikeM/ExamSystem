using System.Collections.Generic;
using ExamSystem.Business.Abstract;
using ExamSystem.DataAccess.Abstract;
using ExamSystem.Entities.Concrete;

namespace ExamSystem.Business.Concrete
{
    public class StudentStatusManager : IStudentStatusService
    {
        private IStudentStatusDal _studentStatusDal;

        public StudentStatusManager(IStudentStatusDal studentStatusDal)
        {
            _studentStatusDal = studentStatusDal;
        }

        public List<StudentStatus> GetByStudentId(int studentId)
        {
            return _studentStatusDal.GetAll(p => p.StudentID == studentId);
        }

        public StudentStatus GetByStudentIdAndQuestionId(int studentId, int questionId)
        {
            return _studentStatusDal.Get(p => p.StudentID == studentId && p.QuestionID == questionId);
        }

        public void Add(StudentStatus studentStatus)
        {
            _studentStatusDal.Add(studentStatus);
        }

        public void Update(StudentStatus studentStatus)
        {
            _studentStatusDal.Update(studentStatus);
        }
    }
}