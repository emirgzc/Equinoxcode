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
	public class ReferanceManager : IReferanceService
	{
		IReferanceDal _ReferanceDal;

		public ReferanceManager(IReferanceDal ReferanceDal)
		{
			_ReferanceDal = ReferanceDal;
		}

		public void ReferanceAdd(Referance Referance)
		{
			_ReferanceDal.Add(Referance);
		}

		public void ReferanceDelete(Referance Referance)
		{
			_ReferanceDal.Delete(Referance);
		}

		public void ReferanceUpdate(Referance Referance)
		{
			_ReferanceDal.Update(Referance);
		}

		public List<Referance> GetReferanceByID(int id)
		{
			return _ReferanceDal.GetAll(x => x.RefID == id);
		}

		public List<Referance> GetAll()
		{
			return _ReferanceDal.GetAll();
		}

		public Referance GetByID(int id)
		{
			return _ReferanceDal.Get(x => x.RefID == id);
		}
	}
}
