using BibliotecaAcademica.App.AppServices.AppServicesBases;
using BibliotecaAcademica.Domain.DomainContextBasic.DomainContext.Entity.Concretes.Exemplares;
using BibliotecaAcademica.Domain.DomainContextBasic.IContracts.IContractsAppServices.IContractsAppEntity.IContractsAppExemplares;
using BibliotecaAcademica.Domain.DomainContextBasic.IContracts.IContractsDomainServices.IContractsDomainServicesEntity.IContractsDomainServicesExemplares;
using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecaAcademica.App.AppServices.AppServicesEntity.AppServicesExemplares
{
    public class AppServicesExemplar : AppServicesBase<Exemplar>, IContractsAppExemplar
    {
        #region Atributo

        private IContractsDomainServicesExemplar appServicesExemplar;

        #endregion

        #region Construtor

        public AppServicesExemplar(IContractsDomainServicesExemplar appServicesExemplar)
            : base(appServicesExemplar)
        {
            this.appServicesExemplar = appServicesExemplar;
        }

        #endregion

        #region Implementação dos Métodos Exemplar



        #endregion
    }
}