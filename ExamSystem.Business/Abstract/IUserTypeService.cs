using System.Collections.Generic;
using ExamSystem.Entities.Concrete;

namespace ExamSystem.Business.Abstract
{
    public interface IUserTypeService
    {
        List<UserType> GetNotAdminType();
    }
}