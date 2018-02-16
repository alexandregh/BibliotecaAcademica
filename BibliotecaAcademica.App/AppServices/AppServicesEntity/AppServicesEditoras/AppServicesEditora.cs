using BibliotecaAcademica.App.AppServices.AppServicesBases;
using BibliotecaAcademica.Domain.DomainContextBasic.DomainContext.Entity.Concretes.Editoras;
using BibliotecaAcademica.Domain.DomainContextBasic.IContracts.IContractsAppServices.IContractsAppEntity.IContractsAppEditoras;
using BibliotecaAcademica.Domain.DomainContextBasic.IContracts.IContractsDomainServices.IContractsDomainServicesEntity.IContractsDomainServicesEditoras;
using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecaAcademica.App.AppServices.AppServicesEntity.AppServicesEditoras
{
    public class AppServicesEditora : AppServicesBase<Editora>, IContractsAppEditora
    {
        #region Atributo

        private IContractsDomainServicesEditora appServicesEditora;

        #endregion

        #region Construtor

        public AppServicesEditora(IContractsDomainServicesEditora appServicesEditora)
            : base(appServicesEditora)
        {
            this.appServicesEditora = appServicesEditora;
        }

        #endregion

        #region Implementação dos Métodos Editora



        #endregion
    }
}