using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TechJobsPersistent.ViewModels
{
    public class AddJobViewModel
    {
        public string Name { get; set; }
         public int EmployerId { get; set; }
        public List<SelectListItem> Employer { get; set; }
        public AddJobViewModel()
        {
        }
    }
}
