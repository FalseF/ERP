﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Core.Domains
{
    public class RoleEmployee : BaseEntity
    {
        public int RoleId { get; set; }
        public int EmployeeId { get; set; }
    }
}