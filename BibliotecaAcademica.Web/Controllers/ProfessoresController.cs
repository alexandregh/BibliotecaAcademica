using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BibliotecaAcademica.Web.Controllers
{
    public class ProfessoresController : Controller
    {
        // GET: Professores
        public ActionResult Index()
        {
            return View();
        }
    }
}