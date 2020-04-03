using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using WebAppMVC.Models;

namespace WebAppMVC.Controllers
{
    public class ProductosController : Controller
    {
        // GET: Productos
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult ListarProductos()
        {
            List<Producto> lista = Metodos.ListarProductos();
                        
            return Json(lista, JsonRequestBehavior.AllowGet);
        }

        public ActionResult TablaProductos()
        {
            return View();
        }

        public JsonResult Fecha()
        {
            DateTime fecha = new DateTime(1985, 12, 20);


            return Json(fecha,JsonRequestBehavior.AllowGet);
        }

        public JsonResult Moneda()
        {
            decimal moneda = 13823.84734M;


            return Json(moneda, JsonRequestBehavior.AllowGet);
        }

        public ActionResult TestFecha()
        {
            return View();
        }
    }
}