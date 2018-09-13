using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Site.Models
{
    public class Table 
    {
        public string UserName { get; set; }

        public DateTime RegistrationDate { get; set; }

        public DateTime AutarizationDate { get; set; }

        public bool Status { get; set; }
    }
}