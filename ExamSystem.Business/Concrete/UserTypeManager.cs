using System.Collections.Generic;
using ExamSystem.Business.Abstract;
using ExamSystem.DataAccess.Abstract;
using ExamSystem.Entities.Concrete;

namespace ExamSystem.Business.Concrete
{
    public class UserTypeManager : IUserTypeService
    {
        private IUserTypeDal _userTypeDal;

        public UserTypeManager(IUserTypeDal userTypeDal)
        {
            _userTypeDal = userTypeDal;
        }

        public List<UserType> GetNotAdminType()
        {
            return _userTypeDal.GetAll(p => p.ID != 1);
        }
    }
}