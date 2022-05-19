using ExamSystem.Business.Abstract;
using ExamSystem.Business.Concrete;
using ExamSystem.DataAccess.Abstract;
using ExamSystem.DataAccess.Concrete.EntityFramework;
using Ninject.Modules;

namespace ExamSystem.Business.DependencyResolvers.Ninject
{
    public class BusinessModule:NinjectModule
    {
        public override void Load()
        {
            Bind<IChoiceFormatService>().To<ChoiceFormatManager>().InSingletonScope();
            Bind<IChoiceFormatDal>().To<EfChoiceFormatDal>().InSingletonScope();

            Bind<IChoiceService>().To<ChoiceManager>().InSingletonScope();
            Bind<IChoiceDal>().To<EfChoiceDal>().InSingletonScope();

            Bind<IExaminerService>().To<ExaminerManager>().InSingletonScope();
            Bind<IExaminerDal>().To<EfExaminerDal>().InSingletonScope();

            Bind<IExamService>().To<ExamManager>().InSingletonScope();
            Bind<IExamDal>().To<EfExamDal>().InSingletonScope();

            Bind<IExamQuestionService>().To<ExamQuestionManager>().InSingletonScope();
            Bind<IExamQuestionDal>().To<EfExamQuestionDal>().InSingletonScope();

            Bind<ILectureService>().To<LectureManager>().InSingletonScope();
            Bind<ILectureDal>().To<EfLectureDal>().InSingletonScope();

            Bind<IQuestionService>().To<QuestionManager>().InSingletonScope();
            Bind<IQuestionDal>().To<EfQuestionDal>().InSingletonScope();

            Bind<ISectionService>().To<SectionManager>().InSingletonScope();
            Bind<ISectionDal>().To<EfSectionDal>().InSingletonScope();

            Bind<IStudentService>().To<StudentManager>().InSingletonScope();
            Bind<IStudentDal>().To<EfStudentDal>().InSingletonScope();

            Bind<IStudentStatisticsService>().To<StudentStatisticsManager>();
            Bind<IStudentStatisticsDal>().To<EfStudentStatisticsDal>();

            Bind<IStudentStatusService>().To<StudentStatusManager>().InSingletonScope();
            Bind<IStudentStatusDal>().To<EfStudentStatusDal>().InSingletonScope();

            Bind<ITimeIntervalService>().To<TimeIntervalManager>().InSingletonScope();
            Bind<ITimeIntervalDal>().To<EfTimeIntervalDal>().InSingletonScope();

            Bind<IUnitService>().To<UnitManager>().InSingletonScope();
            Bind<IUnitDal>().To<EfUnitDal>().InSingletonScope();

            Bind<IUserService>().To<UserManager>().InSingletonScope();
            Bind<IUserDal>().To<EfUserDal>().InSingletonScope();

            Bind<IUserTypeService>().To<UserTypeManager>().InSingletonScope();
            Bind<IUserTypeDal>().To<EfUserTypeDal>().InSingletonScope();







        }
    }
}