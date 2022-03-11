using EntityLayer.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
	public class Contact : IEntity
	{
		[Key]
		public int ConID { get; set; }
		public String NameSurname { get; set; }
		public String Email { get; set; }
		public String Subject { get; set; }
		public String Phone { get; set; }
		public String Message { get; set; }
		public DateTime MessageDate { get; set; }
	}
}
