using BibliotecaAcademica.Domain.DomainContextBasic.DomainContext.Entity.Concretes.Livros;
using BibliotecaAcademica.Domain.DomainContextBasic.IContracts.IContractsInfraEstructure.IContractsSGBDServices.IContractsSGBDEntity.IContractsSGBDLivros;
using BibliotecaAcademica.SGBD.Repository.RepositoryBases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaAcademica.SGBD.Repository.RepositoryEntity.RepositoryLivros
{
    public class RepositoryLivro : RepositoryBase<Livro>, IContractsSGBDLivro
    {
        #region Implementação dos Métodos do Livro



        #endregion
    }
}