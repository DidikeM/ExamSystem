using System.Data.Entity;
using ExamSystem.DataAccess.Abstract;
using ExamSystem.Entities.Concrete;

namespace ExamSystem.DataAccess.Concrete.EntityFramework
{
    public class EfQuestionDal:EfEntityRepositoryBase<Question, ExamSystemContext>,IQuestionDal
    {

    }
}