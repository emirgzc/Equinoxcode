using EntityLayer.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
	public class Slider : IEntity
	{
		[Key]
		public int SliderId { get; set; }
		[StringLength(150)]
		public String SliderImage { get; set; }
		[StringLength(150)]
		public String SliderTitle{ get; set; }
	}
}
