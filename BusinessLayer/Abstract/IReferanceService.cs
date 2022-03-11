using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
	public interface IReferanceService
	{
        List<Referance> GetAll();
        List<Referance> GetReferanceByID(int id);
        Referance GetByID(int id);
        void ReferanceAdd(Referance Referance);
        void ReferanceUpdate(Referance Referance);
        void ReferanceDelete(Referance Referance);
    }
}
