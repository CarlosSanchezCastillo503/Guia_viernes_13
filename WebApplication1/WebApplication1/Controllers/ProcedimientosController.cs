using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ProcedimientosController : Controller
    {
        // GET: Procedimientos
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Suma()
        {
            Procesos D1 = new Procesos();
            String Opera = Request.Params["Boton"];
            D1.N1 = Double.Parse(Request.Form["N1"].ToString());
            D1.N2 = Double.Parse(Request.Form["N2"].ToString());
            
            if (Opera == "Sumar")
            {
                D1.R = D1.N1 + D1.N2;
                D1.Signos = D1.N1 + "+" + D1.N2;
            }
            else if (Opera == "Restar")
            {
                D1.R = D1.N1 - D1.N2;
                D1.Signos = D1.N1 + "-" + D1.N2;

            }
            else if (Opera == "Dividir")
            {
                D1.R = D1.N1 / D1.N2;
                D1.Signos = D1.N1 + "/" + D1.N2;

            }
            else if (Opera == "Multiplicar")
            {
                D1.Signos = D1.N1 + "X" + D1.N2;

                D1.R = D1.N1 * D1.N2;
            }
            return View("Suma", D1);
        }
       
    }
}