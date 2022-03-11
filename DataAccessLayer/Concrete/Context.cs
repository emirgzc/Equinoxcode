using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
	public class Context : DbContext
	{
		public DbSet<About> Abouts { get; set; }
		public DbSet<Contact> Contacts { get; set; }
		public DbSet<Project> Projects { get; set; }
		public DbSet<Referance> Referances { get; set; }
		public DbSet<Services> Services { get; set; }
		public DbSet<Slider> Sliders { get; set; }
		public DbSet<User> Users { get; set; }
	}
}
