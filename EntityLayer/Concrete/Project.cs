using EntityLayer.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
	public class Project : IEntity
	{
		[Key]
		public int ProjectID { get; set; }
		public String ProjectTitle { get; set; }
		public String ProjectDesc { get; set; }
		public String ProjectImg { get; set; }
		public bool isIOS { get; set; }
		public String ProjectIOSLink { get; set; }
		public String ProjectAndroidLink { get; set; }
		public bool Status { get; set; }
	}
}
