using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AspEFCore.WebDemo.Models;
using AspEFCore.Domain;
using AspEFCore.Data;

namespace AspEFCore.WebDemo.Controllers
{
    public class HomeController : Controller
    {
        public readonly MyContext _context;

        public HomeController(MyContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var province = new Province
            {
                Name = "天津",
                Population = 1_000_000
            };
            var company = new Company
            {
                Name = "泰达",
                EstablishData = new DateTime(1995, 12, 22),
                LegalPerson = "Secret Man"
            };
            //var province1 = new Province
            //{
            //    Name = "上海",
            //    Population = 2_100_000
            //};
            //var province2 = new Province
            //{
            //    Name = "安徽",
            //    Population = 6_000_000
            //};
            //_context.Add(province);
            //var listProvinces = new List<Province> { province, province1, province2 };
            //_context.AddRange(listProvinces);
            _context.AddRange(province, company);
            _context.SaveChanges();

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
