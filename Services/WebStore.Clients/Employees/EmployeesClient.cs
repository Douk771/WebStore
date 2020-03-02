using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;
using WebStore.Clients.Base;
using WebStore.Domain.ViewModels;
using WebStore.Interfaces.Services;

namespace WebStore.Clients.Employees
{
    public class EmployeesClient : BaseClient, IEmployeesData
    {
        public EmployeesClient(IConfiguration config) : base (config, "api/employees") { }

        public void Add(EmployeeView Employee)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Edit(int id, EmployeeView Employee)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<EmployeeView> GetAll()
        {
            throw new NotImplementedException();
        }

        public EmployeeView GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}
