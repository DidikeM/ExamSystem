using System.Collections.Generic;
using ExamSystem.Business.Abstract;
using ExamSystem.DataAccess.Abstract;
using ExamSystem.Entities.Concrete;

namespace ExamSystem.Business.Concrete
{
    public class SectionManager : ISectionService
    {
        private ISectionDal _sectionDal;

        public SectionManager(ISectionDal sectionDal)
        {
            _sectionDal = sectionDal;
        }

        public Section GetById(int id)
        {
            return _sectionDal.Get(p => p.ID == id);
        }

        public List<Section> GetByUnitId(int id)
        {
            return _sectionDal.GetAll(p => p.UnitID == id);
        }

        public void Add(Section section)
        {
            _sectionDal.Add(section);
        }
    }
}