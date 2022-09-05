using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Laboratorio03_MVC_Farfan.Models;

namespace Laboratorio03_MVC_Farfan.Controllers
{
    public class BilleteController : Controller
    {
        // GET: Billete
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Calcular(ClsBillete objBillete)
        {
            int total = 0;
            int can100, can50, can20, can10;
            int res100, res50, res20, res10;

            total = objBillete.monto;

            can100 = total / 100;
            res100 = total % 100;

            can50 = res100 / 50;
            res50 = res100 % 50;

            can20 = res50 / 20;
            res20 = res50 % 20;

            can10 = res20 / 10;
            res10 = res20 % 10;

            

            objBillete.b100 = can100;
            objBillete.b50 = can50;
            objBillete.b20 = can20;
            objBillete.b10 = can10;

            return View(objBillete);
        }
    }
}