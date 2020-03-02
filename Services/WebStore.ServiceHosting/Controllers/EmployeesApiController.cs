using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebStore.Domain.ViewModels;
using WebStore.Interfaces.Services;

namespace WebStore.ServiceHosting.Controllers
{
    //[Route("api/[controller]")]
    [Route("api/employees")]
    [ApiController]
    public class EmployeesApiController : ControllerBase, IEmployeesData
    {
        private readonly IEmployeesData _EmployeesData;

        public EmployeesApiController(IEmployeesData EmployeesData) => _EmployeesData = EmployeesData;

        [HttpGet, ActionName("Get")]
        public IEnumerable<EmployeeView> GetAll()
        {
            return _EmployeesData.GetAll();
        }

        //[HttpGet({"id"}), ActionName("Get")]
        [HttpGet("{id}"), ActionName("Get")]
        public EmployeeView GetById(int id) => _EmployeesData.GetById(id);
        
        [HttpPost, ActionName("Post")]
        public void Add([FromBody] EmployeeView Employee)
        {
            _EmployeesData.Add(Employee);
        }

        [HttpPut("{id}"), ActionName("Put")]
        public void Edit(int id, EmployeeView Employee)
        {
            _EmployeesData.Edit(id, Employee);
        }


        [HttpDelete("{id}")]
        public bool Delete(int id)
        {
            return _EmployeesData.Delete(id);
        }

        

        [NonAction]
        public void SaveChanges()
        {
            _EmployeesData.SaveChanges();
        }
    }
}