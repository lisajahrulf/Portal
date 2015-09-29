using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KundPortalen.Models
{
    public class DbRepository : IRepository
    {
        public void CreateUser()
        {
            var newUser = new User
            {
                UserId = 1,
                Name = "Eva"
            };

            var db = new Context();
            db.Users.Add(newUser);
            db.SaveChanges();
        }

        public void DeleteUser()
        {
            throw new NotImplementedException();
        }

        public void EditUser()
        {
            throw new NotImplementedException();
        }

        public void CreateProject()
        {
            throw new NotImplementedException();
        }

        public void DeleteProject()
        {
            throw new NotImplementedException();
        }

        public void EditProject()
        {
            throw new NotImplementedException();
        }

        Project[] ListProject()
        {
            using (var db = new Context())
            {
                return db.Projects.ToArray();
            }
        }

        public void CreateProjectLeader()
        {
            throw new NotImplementedException();
        }

        public void DeleteProjectLeader()
        {
            throw new NotImplementedException();
        }

        ProjectLeader[] ListProjectLeader()
        {
            using (var db = new Context())
            {
                return db.ProjectLeaders.ToArray();
            }
        }

        public void CreateCompany()
        {
            throw new NotImplementedException();
        }

        public void EditCompany()
        {
            throw new NotImplementedException();
        }

        public void DeleteCompany()
        {
            throw new NotImplementedException();
        }

        Company[] ListCompany()
        {
            using (var db = new Context())
            {
                return db.Companies.ToArray();
            }
        }

        Project IRepository.ListProject()
        {
            throw new NotImplementedException();
        }

        ProjectLeader IRepository.ListProjectLeader()
        {
            throw new NotImplementedException();
        }

        Company IRepository.ListCompany()
        {
            throw new NotImplementedException();
        }
    }
}