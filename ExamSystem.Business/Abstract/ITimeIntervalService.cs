using ExamSystem.Entities.Concrete;

namespace ExamSystem.Business.Abstract
{
    public interface ITimeIntervalService
    {
        TimeInterval GetById(int id);
    }
}