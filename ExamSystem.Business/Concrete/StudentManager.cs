using ExamSystem.Business.Abstract;
using ExamSystem.DataAccess.Abstract;
using ExamSystem.Entities.Concrete;

namespace ExamSystem.Business.Concrete
{
    public class StudentManager : IStudentService
    {
        private IStudentDal _studentDal;

        public StudentManager(IStudentDal studentDal)
        {
            _studentDal = studentDal;
        }

        public void Add(Student student)
        {
            _studentDal.Add(student);
        }

        public Student GetById(int id)
        {
            return _studentDal.Get(p => p.ID == id);
        }

        public Student GetByUserId(int userId)
        {
            return _studentDal.Get(p => p.UserID == userId);
        }
    }
}