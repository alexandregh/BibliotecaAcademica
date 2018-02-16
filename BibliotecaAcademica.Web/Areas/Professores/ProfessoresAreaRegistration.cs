using System.Web.Mvc;

namespace BibliotecaAcademica.Web.Areas.Professores
{
    public class ProfessoresAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Professores";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Professores_default",
                "Professores/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}