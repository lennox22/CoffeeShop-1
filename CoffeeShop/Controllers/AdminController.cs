using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;
using MySql.Data.MySqlClient;
using CoffeeShop.Models;

namespace CoffeeShop.Controllers
{
    public class AdminController : Controller
    {
        static MySqlConnection db = new MySqlConnection("Server=localhost;Database=coffeehouse;Uid=root;Password=abc123");

        public IActionResult Index()
        {
            List<product> prod = db.GetAll<product>().ToList();
            return View(prod);
        }
        public IActionResult EditForm(int id)
        {
            product prod = db.Get<product>(id);
            List<product> cats = db.GetAll<product>().ToList();
            ViewBag.categories = cats;
            return View(prod);
        }
        [HttpPost]
        public IActionResult Edit(product prod)
        {
            db.Update(prod);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteForm(int id)
        {
            product prod = db.Get<product>(id);

            return View(prod);
        }
        public IActionResult Delete(int id)
        {
            product prod = db.Get<product>(id);

            db.Delete(prod);
            return RedirectToAction("Index");
        }
        public IActionResult AddForm()
        {
            List<product> cats = db.GetAll<product>().ToList();
            ViewBag.categories = cats;
            return View();
        }
        [HttpPost]
        public IActionResult Add(product prod)
        {
            db.Insert(prod);
            return RedirectToAction("Index");
        }
    }
}
