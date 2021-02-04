using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TechJobsPersistent.Data;
using TechJobsPersistent.Models;
using TechJobsPersistent.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TechJobsPersistent.Controllers
{
    public class EmployerController : Controller
    {
        private JobDbContext context;

        public EmployerController(JobDbContext dbContext)
        {
            context = dbContext;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            List<Employer> employer = context.Employers.ToList();
            return View(employer);
        }

        public IActionResult Add()
        {
            AddEmployerViewModel addEmployer = new AddEmployerViewModel();
            return View(addEmployer);
        }

        public IActionResult ProcessAddEmployerForm(AddEmployerViewModel addEmployer)
        {
            if (ModelState.IsValid)
            {
                Employer newEmployer = new Employer
                {
                    Name = addEmployer.Name,
                    Location = addEmployer.Location
                };

                context.Employers.Add(newEmployer);
                context.SaveChanges();
            }
            //TODO: Add a redirect ?
            return View();
        }

        public IActionResult About(int id)
        {

            return View();
        }
    }
}
