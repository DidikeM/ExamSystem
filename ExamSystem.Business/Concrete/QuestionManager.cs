﻿using ExamSystem.Business.Abstract;
using ExamSystem.DataAccess.Abstract;
using ExamSystem.Entities.Concrete;

namespace ExamSystem.Business.Concrete
{
    public class QuestionManager:IQuestionService
    {
        private IQuestionDal _questionDal;

        public QuestionManager(IQuestionDal questionDal)
        {
            _questionDal = questionDal;
        }

        public Question GetById(int id)
        {
            return _questionDal.Get(p => p.ID == id);
        }

        public void Add(Question question)
        {
            _questionDal.Add(question);
        }

        public void Update(Question question)
        {
            _questionDal.Update(question);
        }
    }
}