using System.Collections.Generic;
using ExamSystem.Entities.Concrete;

namespace ExamSystem.Business.Abstract
{
    public interface IChoiceFormatService
    {
        List<ChoiceFormat> GetAll();
    }
}