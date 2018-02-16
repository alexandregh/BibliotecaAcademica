using BibliotecaAcademica.App.AppServices.AppServicesBases;
using BibliotecaAcademica.Domain.DomainContextBasic.DomainContext.Entity.Concretes.Livros;
using BibliotecaAcademica.Domain.DomainContextBasic.IContracts.IContractsAppServices.IContractsAppEntity.IContractsAppLivros;
using BibliotecaAcademica.Domain.DomainContextBasic.IContracts.IContractsDomainServices.IContractsDomainServicesEntity.IContractsDomainServicesLivros;
using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecaAcademica.App.AppServices.AppServicesEntity.AppServicesLivros
{
    public class AppServicesLivro : AppServicesBase<Livro>, IContractsAppLivro
    {
        #region Atributo

        private IContractsDomainServicesLivro appServicesLivro;

        #endregion

        #region Construtor

        public AppServicesLivro(IContractsDomainServicesLivro appServicesLivro)
            : base(appServicesLivro)
        {
            this.appServicesLivro = appServicesLivro;
        }

        #endregion

        #region Implementação dos Métodos Livro



        #endregion
    }
}