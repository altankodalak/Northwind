using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Northwind.API.Models
{
    public partial class Logs
    {
        public int Id { get; set; }
        public DateTime? LogDate { get; set; }
        public string LogDescription { get; set; }
    }
}
