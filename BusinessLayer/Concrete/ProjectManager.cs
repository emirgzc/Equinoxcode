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
	public class ProjectManager : IProjectService
	{
		IProjectDal _ProjectDal;

		public ProjectManager(IProjectDal ProjectDal)
		{
			_ProjectDal = ProjectDal;
		}

		public void ProjectAdd(Project Project)
		{
			_ProjectDal.Add(Project);
		}

		public void ProjectDelete(Project Project)
		{
			_ProjectDal.Delete(Project);
		}

		public void ProjectUpdate(Project Project)
		{
			_ProjectDal.Update(Project);
		}

		public List<Project> GetProjectByID(int id)
		{
			return _ProjectDal.GetAll(x => x.ProjectID == id);
		}

		public List<Project> GetAll()
		{
			return _ProjectDal.GetAll();
		}

		public Project GetByID(int id)
		{
			return _ProjectDal.Get(x => x.ProjectID == id);
		}
	}
}
