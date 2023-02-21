using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Northwind.API.DTO;
using Northwind.API.Models;
using Northwind.API.Repository;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;

namespace Northwind.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeRepository employeeRepository;

        public EmployeeController(IEmployeeRepository employeeRepository)
        {
            this.employeeRepository = employeeRepository;
        }
        public IActionResult GetEmployees()
        {
           

            return Ok(employeeRepository.GetEmployees());
        }


        //Create
        [HttpPost]
        public IActionResult CreateEmployee(EmployeeDTO model) {
            

            var result=employeeRepository.CreateEmployee(model);
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteEmplopyee(int id)
        {
            var result = employeeRepository.DeleteEmployee(id);
            return Ok(result);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateEmployee(int id, EmployeeDTO model)
        {
            var result=employeeRepository.UpdateEmployee(id, model);
            return Ok(result);
        }

        [HttpGet]
       
        public IActionResult SearchEmployee([FromBody]string value)
        {
            var result = employeeRepository.SearchEmployee(value);

            return Ok(result);
        }

    }
}
