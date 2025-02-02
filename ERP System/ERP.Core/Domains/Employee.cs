using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Core.Domains
{
    public class Employee : BaseEntity
    {
        public int SystemId { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public DateTime HireDate { get; set; } 
        public string Email { get; set; } = string.Empty;
        public string Designation {  get; set; } = string.Empty;
        public string PresentAddress {  get; set; } = string.Empty;
        public string ParmanentAddress {  get; set; } = string.Empty;
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate {  get; set; }
        public string Status { get; set; } = string.Empty;
        public decimal Salary { get; set; }
        public string Password { get; set; } = string.Empty;
        
        // Navigation properties
        public SystemInfo SystemInfo { get; set; } = default!;
        public ICollection<EmployeeDocument> EmployeeDocuments { get; set; } = new List<EmployeeDocument>();
        public ICollection<RoleEmployee> RoleEmployees { get; set; } = new List<RoleEmployee>();
    }
}
