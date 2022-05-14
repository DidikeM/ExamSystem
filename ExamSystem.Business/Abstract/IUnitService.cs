using ExamSystem.DataAccess.Abstract;
using ExamSystem.Entities.Concrete;

namespace ExamSystem.Business.Abstract
{
    public interface IUnitService
    {
        Unit GetById(int unitID);
    }
}