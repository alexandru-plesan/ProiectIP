using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class MaterialeController : Controller
    {
        //Anul I
        public ActionResult Analiza_matematica()
        {
          ViewBag.Message = "Analiza matematica";
            return View();
        }
        public ActionResult Algebra()
        {
            ViewBag.Message = "Algebra";
            return View();
        }
        public ActionResult Programarea_calculatoarelor()
        {
            ViewBag.Message = ">Programarea calculatoarelor";
            return View();
        }
        public ActionResult Proiectare_asistata()
        {
            ViewBag.Message = "Proiectare asistata de calculator";
            return View();
        }
        public ActionResult Fizica()
        {
            ViewBag.Message = "Fizica";
            return View();
        }
        public ActionResult Programare_orientata()
        {
            ViewBag.Message = "Programare orientata pe obiecte";
            return View();
        }

        //Anul II
        public ActionResult Grafica_calculator()
        {
            ViewBag.Message = "Grafica pe calculator";
            return View();
        }
        public ActionResult Fundamenta_retele()
        {
            ViewBag.Message = "Fundamente ale retelelor de calculatoare";
            return View();
        }
        public ActionResult Baze_date()
        {
            ViewBag.Message = "Baze de date";
            return View();
        }
        public ActionResult Managementul_proiectelor()
        {
            ViewBag.Message = "Managementul proiectelor";
            return View();
        }
        public ActionResult Fundamente_rutare()
        {
            ViewBag.Message = "Fundamente ale rutarii in retea";
            return View();
        }
        public ActionResult Educatie_antreprenoriala()
        {
            ViewBag.Message = "Educatie antreprenoriala";
            return View();
        }

        //Anul III
        public ActionResult Proiectare_bd()
        {
            ViewBag.Message = "Proiectarea bazelor de date";
            return View();
        }
        public ActionResult Sisteme_operare()
        {
            ViewBag.Message = "Sisteme de operare";
            return View();
        }
        public ActionResult Arhitectura_sistemelor_calcul()
        {
            ViewBag.Message = "Arhitectura sistemelor de calcul";
            return View();
        }
        public ActionResult Inteligenta_artificiala()
        {
            ViewBag.Message = "Inteligenta artificiala";
            return View();
        }
        public ActionResult Arhitectura_sistemelor_paralele()
        {
            ViewBag.Message = "Arhitectura sistemelor paralele";
            return View();
        }
        public ActionResult Metode_dezvoltare_software()
        {
            ViewBag.Message = "Metode de dezvoltare software";
            return View();
        }

        //Anul IV
        public ActionResult Sisteme_distribuite()
        {
            ViewBag.Message = "Sisteme distribuite";
            return View();
        }
        public ActionResult Ingineria_programarii()
        {
            ViewBag.Message = "Ingineria programarii";
            return View();
        }
        public ActionResult Dezvoltarea_WEB()
        {
            ViewBag.Message = "Dezvoltarea aplicatiilor WEB";
            return View();
        }
        public ActionResult Compilatoare_translatoare()
        {
            ViewBag.Message = "Compilatoare si translatoare";
            return View();
        }
        public ActionResult Testarea_sistemelor_software()
        {
            ViewBag.Message = "Testarea sistemelor software";
            return View();
        }
        public ActionResult Comert_electronic()
        {
            ViewBag.Message = "Comert electronic";
            return View();
        }

	}
}