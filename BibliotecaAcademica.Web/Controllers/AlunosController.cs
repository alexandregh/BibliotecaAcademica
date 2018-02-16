using BibliotecaAcademica.Domain.DomainContextBasic.DomainContext.Entity.Concretes.Alunos;
using BibliotecaAcademica.Domain.DomainContextBasic.IContracts.IContractsAppServices.IContractsAppEntity.IContractsAppAlunos;
using BibliotecaAcademica.Web.Models.Alunos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BibliotecaAcademica.Web.Controllers
{
    public class AlunosController : Controller
    {
        #region Atributo

        private IContractsAppAluno appServicesAluno;

        #endregion

        #region Construtor

        public AlunosController()
        {

        }

        public AlunosController(IContractsAppAluno appServicesAluno)
        {
            this.appServicesAluno = appServicesAluno;
        }

        #endregion

        #region Páginas

        // GET: Alunos
        public ActionResult Index()
        {
            return View();
        }

        // GET: Cadastro Alunos
        [Route("CadastroAluno")]
        public ActionResult CadastroAluno()
        {
            return View();
        }

        // GET: Recuperação Codigo
        public ActionResult RecuperacaoCodigo()
        {
            return View();
        }

        #endregion

        #region Métodos

        // Realizar Cadastro de Aluno no Sistema...
        public JsonResult CadastrarAuno(ViewModelCadastrarAluno modelCadastroAluno)
        {
            if(ModelState.IsValid)
            {
                try
                {

                }
                catch (Exception ex)
                {
                    return Json($"Ocorreu o seguinte erro: {ex.Message}.");
                }
            }            
            return Json("Os dados do cadastro do Aluno estão incorretos. Tente novamente.");            
        }

        //_____________________________________________

        // Realizar Login no Sistema como Aluno...
        public JsonResult LogarAluno(ViewModelLogarAluno model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    Aluno aluno = new Aluno();
                    aluno.SetEmail(model.Email);
                    aluno.SetNovoCodigoUsuario(model.Codigo);

                    aluno = appServicesAluno.AppPesquisarPorEmailCodigo(aluno.Email, aluno.CodigoUsuario);
                    if (aluno != null)
                    {
                        appServicesAluno.AppRealizarLogin(aluno);
                    }
                    else
                    {
                        return Json($"Não foi possível encontrar o aluno. Certifique-se que seu email {aluno.Email} e sua Senha estejam cadastrados.");
                    }
                    ModelState.Clear();

                }
                catch (Exception ex)
                {
                    return Json($"Ocorreu o seguinte erro: {ex.Message}.");
                }
            }
            return Json("Os dados do login do Aluno estão incorretos. Tente novamente.");
        }

        #endregion
    }
}