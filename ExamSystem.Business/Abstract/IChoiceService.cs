using System.Collections.Generic;
using ExamSystem.Entities.Concrete;

namespace ExamSystem.Business.Abstract
{
    public interface IChoiceService
    {
        List<Choice> GetAll();
    }
}