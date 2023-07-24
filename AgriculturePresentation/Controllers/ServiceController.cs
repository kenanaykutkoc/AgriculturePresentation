﻿using AgriculturePresentation.Models;
using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentation.Controllers
{
    public class ServiceController : Controller
    {
        private readonly IServiceService _service;

        public ServiceController(IServiceService service)
        {
            _service = service;
        }


        public IActionResult Index()
        {
            var values = _service.GetListAll();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddService()
        {
            return View(new ServiceAddViewModel());
        }


        [HttpPost]
        public IActionResult AddService(ServiceAddViewModel model )
        {
            if (ModelState.IsValid)
            {
                _service.Insert(new Service()
                {
                    Title = model.Title,
                    Image = model.Image,
                    Description = model.Description
                });

                return RedirectToAction("Index");
            }

            return View(model);            


        }

        public IActionResult DeleteService(int id)
        {
            var values= _service.GetById(id);
            _service.Delete(values);
            return RedirectToAction("Index");


        }

        [HttpGet]

        public IActionResult EditService(int id)
        {
            var values = _service.GetById(id);
            return View(values);
        }

        [HttpPost]

        public IActionResult EditService(Service service)
        {
            _service.Update(service);
            return RedirectToAction("Index");
        }



    }
}
