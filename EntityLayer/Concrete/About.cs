using EntityLayer.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
	public class About : IEntity
	{
		[Key]
		public int AboutId { get; set; }
		public String AboutTitle { get; set; }
		public String AboutDesc { get; set; }
	}
}
