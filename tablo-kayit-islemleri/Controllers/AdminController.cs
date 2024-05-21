using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using tablo_kayit_islemleri.Models;

namespace tablo_kayit_islemleri.Controllers
{
    public class AdminController : Controller
    {
        private readonly DenemeContext context;

        public AdminController(DenemeContext context){
            this.context = context;
        }
        public IActionResult Index()
        {
            return View(context.Products.ToList());
        }
        public IActionResult UrunEkle()
        {
            return View();
        }
        [HttpPost]
        public IActionResult UrunEkle(Urun model)
        {
            if(!ModelState.IsValid){
                return View(model);
            }
            context.Products.Add(model);
            context.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult UrunGuncelle(int id)
        {
            Urun ?kayit = context.Products.FirstOrDefault(x=>x.Id==id);
            return View(kayit);
        }

        [HttpPost]
        public IActionResult UrunGuncelle(Urun model)
        {
            if(!ModelState.IsValid){
                return View(model);
            }
            context.Products.Update(model);
            context.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult UrunSil(int id)
        {
            Urun ?kayit = context.Products.FirstOrDefault(x=>x.Id==id);
            context.Products.Remove(kayit);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}