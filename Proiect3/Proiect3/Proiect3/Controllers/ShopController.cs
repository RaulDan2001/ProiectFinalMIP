using Proiect3.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Proiect3.Controllers
{
    public class ShopController : Controller
    {
        ProductModelDbContext dbCtx = new ProductModelDbContext();
        public ActionResult Index()
        {
            return View(dbCtx.Products.ToList());
        }

        [HttpGet]
        public ActionResult Create()
        {
            ProductModel product = new ProductModel();
            return View(product);
        }

        [HttpPost]
        public ActionResult Create(ProductModel product)
        {
            dbCtx.Products.Add(product);
            dbCtx.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Details(int? id)
        {
            if (id != null)
            {
                ProductModel product = dbCtx.Products.Find(id);
                return View(product);
            }
            else return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(int? id)
        {
            if (id != null)
            {
                ProductModel product = dbCtx.Products.Find(id);
                return View(product);
            }
            else return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult Edit(ProductModel product)
        {   
            dbCtx.Products.AddOrUpdate(product);
            dbCtx.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            if (id != null)
            {
                ProductModel product = dbCtx.Products.Find(id);
                return View(product);
            }
            else return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult Delete(ProductModel product)
        {
            dbCtx.Entry(product).State = System.Data.Entity.EntityState.Deleted;
            dbCtx.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}