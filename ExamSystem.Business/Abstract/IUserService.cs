using ExamSystem.Entities.Concrete;

namespace ExamSystem.Business.Abstract
{
    public interface IUserService
    {
        bool CheckUserRegister(User user); 
        void Add(User user);
        User GetByUsernamePassword(User user);
    }   
}