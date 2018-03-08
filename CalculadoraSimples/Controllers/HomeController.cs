using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CalculadoraSimples.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        // POST: Home
        [HttpPost]
        public ActionResult Index(int operando1=0, int operando2=0, string operador="")
        {
            int resultado = 0; //variavel AUX
            switch (operador)  //Calc resultado
            {
                case "+": resultado = operando1 + operando2; break; //soma
                case "-": resultado = operando1 - operando2; break; //sub
                case "x": resultado = operando1 * operando2; break; //mult
                case ":": resultado = operando1 / operando2; break; //div
            }
            ViewBag.Operando1 = operando1;
            ViewBag.Operador = operador;
            ViewBag.Operando2 = operando2;
            ViewBag.Resultado = resultado; //entregar os dados a view            
            return View(); //invocar a view
        }
    }
}