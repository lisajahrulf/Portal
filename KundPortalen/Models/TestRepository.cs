using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KundPortalen.Models
{
    //Just a testrepository that takes hardcoded data in

    public class TestRepository : IRepository
    {
        public void CreateCompany()
        {
            throw new NotImplementedException();
        }

        public void CreateCustomer()
        {
            throw new NotImplementedException();
        }

        public void CreateProject()
        {
            throw new NotImplementedException();
        }

        public void CreateProjectLeader()
        {
            throw new NotImplementedException();
        }

        public void CreateUser()
        {
            throw new NotImplementedException();
        }

        public void DeleteCompany()
        {
            throw new NotImplementedException();
        }

        public void DeleteProject()
        {
            throw new NotImplementedException();
        }

        public void DeleteProjectLeader()
        {
            throw new NotImplementedException();
        }

        public void DeleteUser()
        {
            throw new NotImplementedException();
        }

        public void EditCompany()
        {
            throw new NotImplementedException();
        }

        public void EditCustomer()
        {
            throw new NotImplementedException();
        }

        public void EditProject()
        {
            throw new NotImplementedException();
        }

        public void EditUser()
        {
            throw new NotImplementedException();
        }

        public Company[] ListCompany()
        {
            return new Company[]
                {
                    new Company { CompanyId = 1, CompanyName = "Posten Ab" },
                    new Company { CompanyId = 2, CompanyName = "Systembolaget Ab"}
                };
        }

        public Customer[] ListCustomer()
        {
            return new Customer[]
                {
                    new Customer { Id = 1, FirstName = "Hans", LastName = "Andersson" },
                    new Customer { Id = 2, FirstName = "Karin", LastName = "Larsson" }
                };
        }

        public Project[] ListProject()
        {
            return new Project[]
                {
                     new Project { ProjectId = 1, Name = "Posten" },
                     new Project { ProjectId = 2, Name = "Systembolaget" }
                };
        }

        public ProjectLeader[] ListProjectLeader()
        {
            return new ProjectLeader[]
                {
                    new ProjectLeader { ProjectLeaderId = 1, FirstName = "Eva", LastName = "Oscarsson" },
                    new ProjectLeader { ProjectLeaderId = 2, FirstName = "Olle", LastName = "Junior" },
                    new ProjectLeader { ProjectLeaderId = 3, FirstName = "Hilda", LastName = "Karlsson" }
                };
        }

    }
}
