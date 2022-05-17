using ExamSystem.Business.Abstract;
using ExamSystem.Business.DependencyResolvers.Ninject;
using ExamSystem.DataAccess.Abstract;
using ExamSystem.Entities.Concrete;

namespace ExamSystem.Business.Concrete
{
    public class UserManager : IUserService
    {
        private IUserDal _userDal;
        private IStudentService _studentService = InstanceFactory.GetInstance<IStudentService>();
        private IExaminerService _examinerService = InstanceFactory.GetInstance<IExaminerService>();

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public bool CheckUserRegister(User user)
        {
            return (_userDal.Get(p => p.Username == user.Username) == null) && (_userDal.Get(p => p.EMail == user.EMail) == null);
        }

        public void Add(User user)
        {
            _userDal.Add(user);

            if (user.UserTypeID == 2)
            {
                _examinerService.Add(new Examiner() { UserID = user.ID, ApprovalStatus = false });
            }
            else if (user.UserTypeID == 3)
            {
                _studentService.Add(new Student() { UserID = user.ID, TimeIntervalID = 1 });
            }
        }

        public User GetByUsernamePassword(User user)
        {
            return _userDal.Get(p => p.Username == user.Username && p.Password == user.Password);
        }
    }
}