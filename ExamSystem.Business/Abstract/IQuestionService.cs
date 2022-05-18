using System.Collections.Generic;
using ExamSystem.Entities.Concrete;

namespace ExamSystem.Business.Abstract
{
    public interface IQuestionService
    {
        Question GetById(int id);
        void Add(Question question);
        void Update(Question question);
        List<Question> GetAll();
        List<int> GetAllIds();
    }
}