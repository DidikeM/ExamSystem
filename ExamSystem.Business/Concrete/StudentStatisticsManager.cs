using System.Collections.Generic;
using ExamSystem.Business.Abstract;
using ExamSystem.DataAccess.Abstract;
using ExamSystem.Entities.Concrete;

namespace ExamSystem.Business.Concrete
{
    public class StudentStatisticsManager : IStudentStatisticsService
    {
        private IStudentStatisticsDal _studentStatisticsDal;

        public StudentStatisticsManager(IStudentStatisticsDal studentStatisticsDal)
        {
            _studentStatisticsDal = studentStatisticsDal;
        }

        public StudentStatistics GetByStudentIdAndSectionId(int studentId, int sectionId)
        {
            return _studentStatisticsDal.Get(p => p.StudentID == studentId && p.SectionID == sectionId);
        }

        public void Add(StudentStatistics studentStatistics)
        {
            _studentStatisticsDal.Add(studentStatistics);
        }

        public void Update(StudentStatistics studentStatistics)
        {
            _studentStatisticsDal.Update(studentStatistics);
        }

        public List<StudentStatistics> GetByStudentId(int studentId)
        {
            return _studentStatisticsDal.GetAll(p => p.StudentID == studentId);
        }
    }
}