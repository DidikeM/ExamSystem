using ExamSystem.DataAccess.Abstract;
using ExamSystem.Entities.Concrete;

namespace ExamSystem.DataAccess.Concrete.EntityFramework
{
    public class EfExamDal:EfEntityRepositoryBase<Exam, ExamSystemContext>,IExamDal
    {
        
    }
}