using System.Web.Mvc;

namespace BibliotecaAcademica.Web.Areas.FuncionarioGerente
{
    public class FuncionarioGerenteAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "FuncionarioGerente";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "FuncionarioGerente_default",
                "FuncionarioGerente/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}