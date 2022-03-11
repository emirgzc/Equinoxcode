﻿using EntityLayer.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
	public class Services : IEntity
	{
		[Key]
		public int ServicesId { get; set; }
		public String Icon { get; set; }
		public String ServicesTitle { get; set; }
		public String ServicesDesc { get; set; }
		public bool Status { get; set; }
	}
}
