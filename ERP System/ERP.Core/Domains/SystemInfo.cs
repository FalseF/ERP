using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Core.Domains
{
    public class SystemInfo : BaseEntity
    {
        public string Name { get; set; } = String.Empty;

        // Navigation properties
        public ICollection<Employee> Employees { get; set; } = new List<Employee>();
    }
}
