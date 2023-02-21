using Northwind.API.DTO;
using System.Collections.Generic;

namespace Northwind.API.Repository
{
    public interface IEmployeeRepository
    {
        List<EmployeeDTO> GetEmployees();
        string CreateEmployee(EmployeeDTO employee);

        string DeleteEmployee(int id);

        string UpdateEmployee(int id, EmployeeDTO employee);


        List<EmployeeDTO> SearchEmployee(string value);


    }
}
