using EntityLayer.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
	public class User : IEntity
	{
		[Key]
		public int UserID { get; set; }
		public String NameSurname { get; set; }
		public String Image { get; set; }
		public String Job { get; set; }
		public String Desc { get; set; }
		public String Instagram { get; set; }
		public String Linkedin { get; set; }
		public String Github { get; set; }
		public bool Status { get; set; }
	}
}
