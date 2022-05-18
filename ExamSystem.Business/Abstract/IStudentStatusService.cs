using System.Collections.Generic;
using ExamSystem.Entities.Concrete;

namespace ExamSystem.Business.Abstract
{
    public interface IStudentStatusService
    {
        List<StudentStatus> GetByStudentId(int id);
        StudentStatus GetByStudentIdAndQuestionId(int studentId, int questionId);
        void Add(StudentStatus studentStatus);
        void Update(StudentStatus studentStatus);
    }
}