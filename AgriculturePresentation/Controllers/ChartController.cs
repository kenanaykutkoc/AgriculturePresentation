﻿using AgriculturePresentation.Models;
using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentation.Controllers
{
    public class ChartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ProductChart()
        {
            List<ProductClass> productClasses = new List<ProductClass>();
            productClasses.Add(new ProductClass()
            {
                productname = "Buğday",
                productvalue = 970
            });

            productClasses.Add(new ProductClass
            {
                productname = "Mercimek",
                productvalue = 570
            });

            productClasses.Add(new ProductClass
            {
                productname = "Arpa",
                productvalue = 620
            });

            productClasses.Add(new ProductClass
            {
                productname = "Pirinç",
                productvalue = 380
            });

            productClasses.Add(new ProductClass
            {
                productname = "Domates",
                productvalue = 870
            });

            return Json(new { jsonlist = productClasses });

        }
    }
}
