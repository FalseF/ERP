using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Core.Domains
{
    public class Permission : BaseEntity
    {
        public string Name { get; set; } = String.Empty;
        public int SystemId { get; set; }
        public ICollection<RolePermission> RolePermissions { get; set; } = new List<RolePermission>();
    }
}
