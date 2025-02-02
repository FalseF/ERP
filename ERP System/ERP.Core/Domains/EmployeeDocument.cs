using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Core.Domains
{
    public class EmployeeDocument : BaseEntity
    {
        public int EmployeeId { get; set; }
        public string Type { get; set; } = String.Empty;
        public DateTime UploadedDate { get; set; }
        public string Path { get; set; } = String.Empty;

        // Navigation property
        public Employee Employee { get; set; } = default!;
    }
}
