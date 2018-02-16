using BibliotecaAcademica.Domain.DomainContextBasic.DomainContext.Entity.Concretes.Funcionarios;
using BibliotecaAcademica.Domain.DomainContextBasic.DomainServices.DomainServicesBases;
using BibliotecaAcademica.Domain.DomainContextBasic.IContracts.IContractsDomainServices.IContractsDomainServicesEntity.IContractsDomainServicesFuncionarios;
using BibliotecaAcademica.Domain.DomainContextBasic.IContracts.IContractsInfraEstructure.IContractsSGBDServices.IContractsSGBDEntity.IContractsSGBDFuncionarios;
using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecaAcademica.Domain.DomainContextBasic.DomainServices.DomainServicesEntity.DomainServicesFuncionarios
{
    public class DomainServicesFuncionario : DomainServicesBase<Funcionario>, IContractsDomainServicesFuncionario
    {
        #region Atributo

        private IContractsSGBDFuncionario serviceFuncionario;

        #endregion

        #region Construtor

        public DomainServicesFuncionario(IContractsSGBDFuncionario serviceFuncionario)
            :base(serviceFuncionario)
        {
            this.serviceFuncionario = serviceFuncionario;
        }

        #endregion

        #region Implementação dos Métodos do Funcionário



        #endregion
    }
}