using System.Collections.Generic;
using ExamSystem.Business.Abstract;
using ExamSystem.DataAccess.Abstract;
using ExamSystem.Entities.Concrete;

namespace ExamSystem.Business.Concrete
{
    public class ChoiceManager:IChoiceService
    {
        private IChoiceDal _choiceDal;

        public ChoiceManager(IChoiceDal choiceDal)
        {
            _choiceDal = choiceDal;
        }
        public List<Choice> GetAll()
        {
            return _choiceDal.GetAll();
        }
    }
}