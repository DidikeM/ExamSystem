using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using ExamSystem.Entities.Concrete;

namespace ExamSystem.DataAccess.Abstract
{
    public interface IQuestionDal:IEntityRepository<Question>
    {
        List<T> GetSelectedAll<T>(Expression<Func<Question, T>> filter);
    }
}