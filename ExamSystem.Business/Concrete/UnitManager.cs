using System.Collections.Generic;
using ExamSystem.Business.Abstract;
using ExamSystem.DataAccess.Abstract;
using ExamSystem.Entities.Concrete;

namespace ExamSystem.Business.Concrete
{
    public class UnitManager : IUnitService
    {
        private IUnitDal _unitDal;

        public UnitManager(IUnitDal unitDal)
        {
            _unitDal = unitDal;
        }

        public Unit GetById(int id)
        {
            return _unitDal.Get(p => p.ID == id);
        }

        public List<Unit> GetByLectureId(int id)
        {
            return _unitDal.GetAll(p => p.LectureID == id);
        }
    }
}