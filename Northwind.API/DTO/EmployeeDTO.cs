using System;

namespace Northwind.API.DTO
{
    public class EmployeeDTO
    {
        public int Id { get; set; }

        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Title { get; set; }
        public string Country { get; set; }
        public DateTime? HireDate { get; set; }
    }
}
