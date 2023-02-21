using Microsoft.AspNetCore.Mvc;
using Northwind.API.DTO;
using Northwind.API.Models;
using Northwind.API.Repository;
using System.Collections.Generic;
using System.Linq;


namespace Northwind.API.Service
{
    public class EmployeeService : IEmployeeRepository
    {
        private readonly northwindContext _context;



        public EmployeeService(northwindContext context)
        {
            _context = context;
        }

        public string CreateEmployee(EmployeeDTO employee)
        {
            try
            {
                Employees newEmployee = new Employees()
                {
                    FirstName = employee.Firstname,
                    LastName = employee.Lastname,
                    Title = employee.Title,
                    HireDate = employee.HireDate,
                    Country = employee.Country
                };


             _context.Employees.Add(newEmployee);
              _context.SaveChanges();
                return "Çalışan Eklendi!";
            }
            catch (System.Exception ex)
            {

                return ex.Message;
            }
        }

        public string DeleteEmployee(int id)
        {
            try
            {
                var employee = _context.Employees.Find(id);
                if (employee != null)
                {
                    _context.Employees.Remove(employee);
                    _context.SaveChanges();
                    return "silme işlemi başarılı";
                }
                else
                {
                    return "çalışan bulunamadı!";
                }
            }
            catch (System.Exception ex)
            {
                return ex.Message;
            }
        }


        #region Uzun transfer işlemi
        //var employees = context.Employees.ToList();

        //List<EmployeeDTO> employeesDTO = new List<EmployeeDTO>();

        //foreach (Employees employee in context.Employees.ToList())
        //{
        //    EmployeeDTO employeeDTO = new EmployeeDTO();
        //    employeeDTO.Id = employee.EmployeeId;
        //    employeeDTO.Firstname=employee.FirstName;
        //    employeeDTO.Lastname=employee.LastName;
        //    employeeDTO.HireDate = employee.HireDate;

        //    employeesDTO.Add(employeeDTO);

        //} 
        #endregion

        //todo: Automapper Nedir? Örneklerle açıklayın.
        public List<EmployeeDTO> GetEmployees()
        {
            var employees = _context.Employees.Select(x => new EmployeeDTO
            {
                Id = x.EmployeeId,
                Firstname = x.FirstName,
                Lastname = x.LastName,
                HireDate = x.HireDate,
                Title=x.Title,
                Country=x.Country,
            }).ToList();

            return employees;
        }

        
        public List<EmployeeDTO> SearchEmployee(string value)
        {
            var result = _context.Employees.Where(x => x.FirstName.Contains(value) || x.LastName.Contains(value)).Select(x => new EmployeeDTO
            {
                Id = x.EmployeeId,
                Title = x.Title,
                Firstname = x.FirstName,
                Lastname = x.LastName,
                HireDate = x.HireDate
            }).ToList();

            return result;
        }

        public string UpdateEmployee(int id, EmployeeDTO employee)
        {
            try
            {
                var updated = _context.Employees.Find(id);

                if (updated != null)
                {
                    updated.Title= employee.Title;
                    updated.Country= employee.Country;
                    updated.FirstName = employee.Firstname;
                    updated.LastName = employee.Lastname;
                    updated.HireDate = employee.HireDate;

                    _context.SaveChanges();
                    return "güncelleme başarılı!";
                }
                else
                {
                    return "çalışan bulunamadı!";
                }
            }
            catch (System.Exception)
            {

                throw;
            }


        }
    }
}
