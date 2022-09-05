using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Laboratorio03_MVC_Farfan.Models;

namespace Laboratorio03_MVC_Farfan.Controllers
{
    public class TablaController : Controller
    {
        // GET: Tabla
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GenerarTabla(ClsTabla objTabla)
        {

            return View(objTabla);
        }
    }
}