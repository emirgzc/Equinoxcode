using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
	public class UserManager : IUserService
	{
		IUserDal _UserDal;

		public UserManager(IUserDal UserDal)
		{
			_UserDal = UserDal;
		}

		public void UserAdd(User User)
		{
			_UserDal.Add(User);
		}

		public void UserDelete(User User)
		{
			_UserDal.Delete(User);
		}

		public void UserUpdate(User User)
		{
			_UserDal.Update(User);
		}

		public List<User> GetUserByID(int id)
		{
			return _UserDal.GetAll(x => x.UserID == id);
		}

		public List<User> GetAll()
		{
			return _UserDal.GetAll();
		}

		public User GetByID(int id)
		{
			return _UserDal.Get(x => x.UserID == id);
		}
	}
}
