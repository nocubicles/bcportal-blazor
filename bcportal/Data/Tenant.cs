using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bcportal.Data
{
    public class Tenant
    {
        public int TenantId { get; set; }
        public string Name { get; set; }
        public List<ApplicationUser> ApplicationUsers { get; set; }
    }
}
