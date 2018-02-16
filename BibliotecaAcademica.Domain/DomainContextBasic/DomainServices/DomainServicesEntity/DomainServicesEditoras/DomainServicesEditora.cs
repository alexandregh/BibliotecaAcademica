using BibliotecaAcademica.Domain.DomainContextBasic.DomainContext.Entity.Concretes.Editoras;
using BibliotecaAcademica.Domain.DomainContextBasic.DomainServices.DomainServicesBases;
using BibliotecaAcademica.Domain.DomainContextBasic.IContracts.IContractsDomainServices.IContractsDomainServicesEntity.IContractsDomainServicesEditoras;
using BibliotecaAcademica.Domain.DomainContextBasic.IContracts.IContractsInfraEstructure.IContractsSGBDServices.IContractsSGBDEntity.IContractsSGBDEditoras;
using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecaAcademica.Domain.DomainContextBasic.DomainServices.DomainServicesEntity.DomainServicesEditoras
{
    public class DomainServicesEditora : DomainServicesBase<Editora>, IContractsDomainServicesEditora
    {
        #region Atributo

        private IContractsSGBDEditora serviceEditora;

        #endregion

        #region Construtor

        public DomainServicesEditora(IContractsSGBDEditora serviceEditora)
            : base(serviceEditora)
        {
            this.serviceEditora = serviceEditora;
        }

        #endregion

        #region Implementação dos Métodos da Editora



        #endregion
    }
}