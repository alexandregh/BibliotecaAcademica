using BibliotecaAcademica.App.AppServices.AppServicesBases;
using BibliotecaAcademica.Domain.DomainContextBasic.DomainContext.Entity.Concretes.Autores;
using BibliotecaAcademica.Domain.DomainContextBasic.IContracts.IContractsAppServices.IContractsAppEntity.IContractsAppAutores;
using BibliotecaAcademica.Domain.DomainContextBasic.IContracts.IContractsDomainServices.IContractsDomainServicesEntity.IContractsDomainServicesAutores;
using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecaAcademica.App.AppServices.AppServicesEntity.AppServicesAutores
{
    public class AppServicesAutor : AppServicesBase<Autor>, IContractsAppAutor
    {
        #region Atributo

        private IContractsDomainServicesAutor appServicesAutor;

        #endregion

        #region Construtor

        public AppServicesAutor(IContractsDomainServicesAutor appServicesAutor)
            : base(appServicesAutor)
        {
            this.appServicesAutor = appServicesAutor;
        }

        #endregion

        #region Implementação dos Métodos Autor



        #endregion
    }
}