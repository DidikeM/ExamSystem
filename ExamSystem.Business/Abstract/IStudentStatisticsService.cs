using System.Collections.Generic;
using ExamSystem.Entities.Concrete;

namespace ExamSystem.Business.Abstract
{
    public interface IStudentStatisticsService
    {
        StudentStatistics GetByStudentIdAndSectionId(int studentId, int sectionId);
        void Add(StudentStatistics studentStatistics);
        void Update(StudentStatistics studentStatistics);
        List<StudentStatistics> GetByStudentId(int studentId);
    }
}