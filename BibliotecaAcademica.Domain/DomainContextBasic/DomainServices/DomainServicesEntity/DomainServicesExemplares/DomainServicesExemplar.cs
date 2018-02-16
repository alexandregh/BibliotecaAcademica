using BibliotecaAcademica.Domain.DomainContextBasic.DomainContext.Entity.Concretes.Exemplares;
using BibliotecaAcademica.Domain.DomainContextBasic.DomainServices.DomainServicesBases;
using BibliotecaAcademica.Domain.DomainContextBasic.IContracts.IContractsDomainServices.IContractsDomainServicesEntity.IContractsDomainServicesExemplares;
using BibliotecaAcademica.Domain.DomainContextBasic.IContracts.IContractsInfraEstructure.IContractsSGBDServices.IContractsSGBDEntity.IContractsSGBDExemplares;
using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecaAcademica.Domain.DomainContextBasic.DomainServices.DomainServicesEntity.DomainServicesExemplares
{
    public class DomainServicesExemplar : DomainServicesBase<Exemplar>, IContractsDomainServicesExemplar
    {
        #region Atributo

        private IContractsSGBDExemplar serviceExemplar;

        #endregion

        #region Construtor

        public DomainServicesExemplar(IContractsSGBDExemplar serviceExemplar)
            :base(serviceExemplar)
        {
            this.serviceExemplar = serviceExemplar;
        }

        #endregion

        #region Implementação dos Métodos do Exemplar



        #endregion
    }
}