using BibliotecaAcademica.App.AppServices.AppServicesBases;
using BibliotecaAcademica.Domain.DomainContextBasic.DomainContext.Entity.Concretes.Funcionarios;
using BibliotecaAcademica.Domain.DomainContextBasic.IContracts.IContractsAppServices.IContractsAppEntity.IContractsAppFuncionarios;
using BibliotecaAcademica.Domain.DomainContextBasic.IContracts.IContractsDomainServices.IContractsDomainServicesEntity.IContractsDomainServicesFuncionarios;
using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecaAcademica.App.AppServices.AppServicesEntity.AppServicesFuncionarios
{
    public class AppServicesFuncionario : AppServicesBase<Funcionario>, IContractsAppFuncionario
    {
        #region Atributo

        private IContractsDomainServicesFuncionario appServicesFuncionario;

        #endregion

        #region Construtor

        public AppServicesFuncionario(IContractsDomainServicesFuncionario appServicesFuncionario)
            : base(appServicesFuncionario)
        {
            this.appServicesFuncionario = appServicesFuncionario;
        }

        #endregion

        #region Implementação dos Métodos Funcionario



        #endregion
    }
}