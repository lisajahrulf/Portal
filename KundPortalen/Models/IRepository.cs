using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KundPortalen.Models
{
    public interface IRepository
    {
        //Users
        void CreateUser();
        void DeleteUser();
        void EditUser();

        //Projects
        void CreateProject();
        void DeleteProject();
        void EditProject();
        Project ListProject();

        //Projects leader
        void CreateProjectLeader();
        void DeleteProjectLeader();
        ProjectLeader ListProjectLeader();

        //Company
        void CreateCompany();
        void EditCompany();
        void DeleteCompany();
        Company ListCompany();

    }
}