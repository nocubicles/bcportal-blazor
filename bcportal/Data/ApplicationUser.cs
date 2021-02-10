using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bcportal.Data
{
    public class ApplicationUser : IdentityUser
    {
        public int TenantId { get; set; }
        public Tenant Tenant { get; set; }
    }
}
