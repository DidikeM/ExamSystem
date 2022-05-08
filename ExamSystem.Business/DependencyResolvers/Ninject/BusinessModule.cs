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
            Bind<IChoiceService>().To<ChoiceManager>().InSingletonScope();
            Bind<IChoiceDal>().To<EfChoiceDal>().InSingletonScope();

            Bind<ILectureService>().To<LectureManager>().InSingletonScope();
            Bind<ILectureDal>().To<EfLectureDal>().InSingletonScope();
        }
    }
}