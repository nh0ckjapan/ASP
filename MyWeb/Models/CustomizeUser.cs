using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWeb.Models
{
    public class CustomizeUser : IdentityUser
    {
        [PersonalData]
        public string FullName { get; set; }
    }
}
