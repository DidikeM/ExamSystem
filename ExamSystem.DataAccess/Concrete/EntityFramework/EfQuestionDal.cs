using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using ExamSystem.DataAccess.Abstract;
using ExamSystem.Entities.Concrete;

namespace ExamSystem.DataAccess.Concrete.EntityFramework
{
    public class EfQuestionDal : EfEntityRepositoryBase<Question, ExamSystemContext>, IQuestionDal
    {
        public List<T> GetSelectedAll<T>(Expression<Func<Question, T>> filter)
        {
            using (ExamSystemContext context = new ExamSystemContext())
            {
                return context.Set<Question>().Select(filter).ToList();
            }
        }
    }
}