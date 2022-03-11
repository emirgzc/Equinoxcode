using EntityLayer.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
	public class Referance : IEntity
	{
		[Key]
		public int RefID { get; set; }
		public String RefImage { get; set; }
		public bool Status { get; set; }
	}
}
