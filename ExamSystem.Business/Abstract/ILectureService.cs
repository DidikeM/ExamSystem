using System.Collections.Generic;
using ExamSystem.Entities.Concrete;

namespace ExamSystem.Business.Abstract
{
    public interface ILectureService
    {
        List<Lecture> GetAll();
        Lecture GetById(int id);
    }
}