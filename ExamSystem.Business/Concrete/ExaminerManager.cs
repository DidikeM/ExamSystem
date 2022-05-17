using ExamSystem.Business.Abstract;
using ExamSystem.DataAccess.Abstract;
using ExamSystem.Entities.Concrete;

namespace ExamSystem.Business.Concrete
{
    public class ExaminerManager : IExaminerService
    {
        private IExaminerDal _examinerDal;

        public ExaminerManager(IExaminerDal examinerDal)
        {
            _examinerDal = examinerDal;
        }

        public void Add(Examiner examiner)
        {
            _examinerDal.Add(examiner);
        }
    }
}