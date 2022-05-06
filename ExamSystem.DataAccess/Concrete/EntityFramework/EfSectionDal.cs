using ExamSystem.DataAccess.Abstract;
using ExamSystem.Entities.Concrete;

namespace ExamSystem.DataAccess.Concrete.EntityFramework
{
    public class EfSectionDal:EfEntityRepositoryBase<Section, ExamSystemContext>,ISectionDal
    {
        
    }
}