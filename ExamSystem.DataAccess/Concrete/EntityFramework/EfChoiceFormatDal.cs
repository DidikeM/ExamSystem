﻿using ExamSystem.DataAccess.Abstract;
using ExamSystem.Entities.Concrete;

namespace ExamSystem.DataAccess.Concrete.EntityFramework
{
    public class EfChoiceFormatDal:EfEntityRepositoryBase<ChoiceFormat, ExamSystemContext>,IChoiceFormatDal
    {
        
    }
}