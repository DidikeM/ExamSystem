using System.Collections.Generic;
using ExamSystem.DataAccess.Abstract;
using ExamSystem.Entities.Concrete;

namespace ExamSystem.Business.Abstract
{
    public interface IUnitService
    {
        Unit GetById(int unitID);
        List<Unit> GetByLectureId(int id);
    }
}