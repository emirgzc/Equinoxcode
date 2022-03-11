using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
	public interface IProjectService
	{
        List<Project> GetAll();
        List<Project> GetProjectByID(int id);
        Project GetByID(int id);
        void ProjectAdd(Project Project);
        void ProjectUpdate(Project Project);
        void ProjectDelete(Project Project);
    }
}
