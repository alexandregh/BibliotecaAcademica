using System.Web.Mvc;

namespace BibliotecaAcademica.Web.Controllers
{
    public class HomeController : Controller
    {
        #region Páginas

        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        #endregion
    }
}