﻿using DataApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace DataApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IDataRepository repository;

        public HomeController(IDataRepository repository)
        {
            this.repository = repository;
        }

        public IActionResult Index()
        {
            return View(repository.GetAllProducts());
        }

        public IActionResult Create()
        {
            ViewBag.CreateMode = true;
            return View("Editor", new Product());
        }

        [HttpPost]
        public IActionResult Create(Product product)
        {
            repository.CreateProduct(product);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Edit(long id)
        {
            ViewBag.CreateMode = false;
            return View("Editor", repository.GetProduct(id));
        }

        [HttpPost]
        public IActionResult Edit(Product product)
        {
            repository.UpdateProduct(product);
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public IActionResult Delete(long id)
        {
            repository.DeleteProduct(id);
            return RedirectToAction(nameof(Index));
        }
    }
}