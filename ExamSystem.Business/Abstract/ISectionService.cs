using ExamSystem.Entities.Concrete;

namespace ExamSystem.Business.Abstract
{
    public interface ISectionService    
    {
        Section GetById(int Id);
    }
}