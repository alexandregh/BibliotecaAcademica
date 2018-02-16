using BibliotecaAcademica.Domain.DomainContextBasic.DomainContext.Entity.Concretes.Autores;
using BibliotecaAcademica.Domain.DomainContextBasic.DomainServices.DomainServicesBases;
using BibliotecaAcademica.Domain.DomainContextBasic.IContracts.IContractsDomainServices.IContractsDomainServicesEntity.IContractsDomainServicesAutores;
using BibliotecaAcademica.Domain.DomainContextBasic.IContracts.IContractsInfraEstructure.IContractsSGBDServices.IContractsSGBDEntity.IContractsSGBDAutores;
using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecaAcademica.Domain.DomainContextBasic.DomainServices.DomainServicesEntity.DomainServicesAutores
{
    public class DomainServicesAutor : DomainServicesBase<Autor>, IContractsDomainServicesAutor
    {
        #region Atributo

        private IContractsSGBDAutor serviceAutor;

        #endregion

        #region Construtor

        public DomainServicesAutor(IContractsSGBDAutor serviceAutor)
            : base(serviceAutor)
        {
            this.serviceAutor = serviceAutor;
        }

        #endregion

        #region Implementação dos Métodos do Autor



        #endregion
    }
}