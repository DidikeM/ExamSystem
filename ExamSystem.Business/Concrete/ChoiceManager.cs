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

        public List<Choice> GetByQuestionId(int questionId)
        {
            return _choiceDal.GetAll(p => p.QuestionID == questionId);
        }

        public void Add(Choice choice)
        {
            _choiceDal.Add(choice);
        }

        public void Update(Choice choice)
        {
            _choiceDal.Update(choice);
        }
    }
}