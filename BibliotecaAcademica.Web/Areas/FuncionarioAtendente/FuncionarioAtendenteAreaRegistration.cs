using System.Web.Mvc;

namespace BibliotecaAcademica.Web.Areas.FuncionarioAtendente
{
    public class FuncionarioAtendenteAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "FuncionarioAtendente";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "FuncionarioAtendente_default",
                "FuncionarioAtendente/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}