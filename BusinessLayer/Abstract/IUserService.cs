using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
	public interface IUserService
	{
        List<User> GetAll();
        List<User> GetUserByID(int id);
        User GetByID(int id);
        void UserAdd(User User);
        void UserUpdate(User User);
        void UserDelete(User User);
    }
}
