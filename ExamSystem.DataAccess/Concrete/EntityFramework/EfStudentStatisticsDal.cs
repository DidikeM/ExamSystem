using ExamSystem.DataAccess.Abstract;
using ExamSystem.Entities.Concrete;

namespace ExamSystem.DataAccess.Concrete.EntityFramework
{
    public class EfStudentStatisticsDal : EfEntityRepositoryBase<StudentStatistics, ExamSystemContext>, IStudentStatisticsDal
    {

    }
}