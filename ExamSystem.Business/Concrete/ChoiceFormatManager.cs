using System.Collections.Generic;
using ExamSystem.Business.Abstract;
using ExamSystem.DataAccess.Abstract;
using ExamSystem.Entities.Concrete;

namespace ExamSystem.Business.Concrete
{
    public class ChoiceFormatManager : IChoiceFormatService
    {
        private IChoiceFormatDal _choiceFormatDal;

        public ChoiceFormatManager(IChoiceFormatDal choiceFormatDal)
        {
            _choiceFormatDal = choiceFormatDal;
        }

        public List<ChoiceFormat> GetAll()
        {
            return _choiceFormatDal.GetAll();
        }
    }
}