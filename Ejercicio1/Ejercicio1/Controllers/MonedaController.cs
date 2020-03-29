using Ejercicio1.Api;
using Ejercicio1.Models;
using Ejercicio1.Models.ListaPaises;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ejercicio1.Controllers
{
    public class MonedaController : Controller
    {

        public MonedaController() {
            ListaPs listaPs = new ListaPs();
            ViewBag.Pais = listaPs.ListaPaises();
        }
        // GET: Moneda
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult Index(DatosCalcular dt)
        {
            if (dt.De == "null" && dt.Para == "null") {
                TempData["msg"] = "Seleccione Paies de Origen y Destino";
            } else if (dt.De=="null") {
                TempData["msg"] = "Seleccione Paies de Origen";
            } else if (dt.Para=="null") {
                TempData["msg"] = "Seleccione Paies de Destino";
            } else if (dt.Cantidad <=0) {
                TempData["msg"] = "No se puede convertir moneda menor que cero";
            } else {
                TempData["msg"] = $"BASE :{dt.De}";
                TempData["para"] = $"CONVERSION :{dt.Para}";
                TempData["cantidad"] = $"TOTAL :{dt.Cantidad}";
                Methodo methodo = new Methodo(dt.De,dt.Para);
                string Respuesta = methodo.ResultadoMoneda();

            }
            return View();
        }
    }
}