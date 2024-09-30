using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.DAL.Models
{
    public class ApplicationUser:IdentityUser
    {
        public bool  isAgree { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }

    }
}
