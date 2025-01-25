using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Core.Domains
{
    public class Role : BaseEntity
    {
        public string Name { get; set; } = String.Empty;
        public int SystemId { get; set; }
        public ICollection<RolePermission> RolePermissions { get; set; } = new List<RolePermission>();
    }
}
