using ExamSystem.Entities.Concrete;

namespace ExamSystem.Business.Abstract
{
    public interface IStudentService
    {
        void Add(Student student);
        Student GetById(int id);
    }
}