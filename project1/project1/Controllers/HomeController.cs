using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using project1.Models;

namespace project1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Index2()
        {
            return View();
        }

        public int Index3()
        {
            return 24;
        }

        public String Index4()
        {
            return "Bugün hava çok sooğuk.";
        }

        public IActionResult Index5()
        {
            var ktp = new List<Kitap>()
            {
                new Kitap()
                {
                    ID = 1,
                    KitapAd = "80 Günde Devri Alem",
                    Yazar = "Jules Verne"
                },

                new Kitap()
                {
                    ID = 2,
                    KitapAd = "Kitap 2",
                    Yazar = "Yazar 2"
                },

                new Kitap()
                {
                    ID = 3,
                    KitapAd = "Kitap 3",
                    Yazar = "Yazar 3"
                },

                new Kitap()
                {
                    ID = 4,
                    KitapAd = "Kitap 4",
                    Yazar = "Yazar 4"
                },

            };
            return View(ktp);
        }

        public IActionResult Index6()
        {
            ViewBag.deger1 = "Kar yağmaya devam ediyor.";

            return View();
        }

        public IActionResult Index7()
        {
            

            return View();
        }

        public IActionResult Index8()
        {


            return View();
        }

        public IActionResult Index9()
        {


            return View();
        }
    }
}
