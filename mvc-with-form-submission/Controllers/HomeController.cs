using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using mvc_with_form_submission.Models;
using mvcwithformsubmission.Models;

namespace mvc_with_form_submission.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            CustomerModel model = new CustomerModel();

            ViewData["Message"] = "Your contact page.";
            SelectList countryList = new SelectList(new List<SelectListItem>
            {   
                new SelectListItem {Selected = true, Text = "please select", Value = "-1"},
                new SelectListItem {Selected = false, Text = "Canada", Value="1"},
                new SelectListItem {Selected = false, Text = "United States", Value="2"}
            });

            model.CountryList = countryList;

            return View(model);
        }

        [HttpPost]
        public IActionResult Contact(string FirstName)
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
