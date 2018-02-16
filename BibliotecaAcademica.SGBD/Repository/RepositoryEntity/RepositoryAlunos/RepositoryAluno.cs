using BibliotecaAcademica.CommonValidationPersistence.MessageValidations.MessageValidationsEntity.MessageValidationsAlunos;
using BibliotecaAcademica.Domain.DomainContextBasic.DomainContext.Entity.Concretes.Alunos;
using BibliotecaAcademica.Domain.DomainContextBasic.IContracts.IContractsInfraEstructure.IContractsSGBDServices.IContractsSGBDEntity.IContractsSGBDAlunos;
using BibliotecaAcademica.SGBD.Repository.RepositoryBases;
using Dapper;
using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Text;

namespace BibliotecaAcademica.SGBD.Repository.RepositoryEntity.RepositoryAlunos
{
    public class RepositoryAluno : RepositoryBase<Aluno>, IContractsSGBDAluno
    {
        #region Implementação dos Métodos do Aluno

        public Aluno PersistencePesquisarPorEmail(string email)
        {
            if (!string.IsNullOrEmpty(email))
            {
                try
                {
                    using (SqlConnection conexaoBD = new SqlConnection(ConfigurationManager.ConnectionStrings["dbBibliotecaAcademica"].ConnectionString))
                    {
                        conexaoBD.Open();
                        string query = "select Email from TBAluno where Email = @Email";
                        var aluno = conexaoBD.QueryFirstOrDefault<Aluno>(query, new { Email = email });
                        return aluno;
                    }                    
                }
                catch (InvalidOperationException ex)
                {
                    throw new InvalidOperationException(nameof(ex.Message));
                }
                catch (ConfigurationErrorsException ex)
                {
                    throw new ConfigurationErrorsException(nameof(ex.Message));
                }
                catch (Exception ex)
                {
                    throw new Exception(nameof(ex.Message));
                }
            }
            else
            {
                this.Dispose(true);
                throw new Exception(MessageAluno.MessageValidationEmailIsNullOrEmpty);
            }
        }

        public Aluno PersistencePesquisarPorEmailCodigo(string email, string codigo)
        {
            if (!string.IsNullOrEmpty(email) && !string.IsNullOrEmpty(codigo))
            {
                try
                {
                    using (SqlConnection conexaoBD = new SqlConnection(ConfigurationManager.ConnectionStrings["dbBibliotecaAcademica"].ConnectionString))
                    {
                        conexaoBD.Open();
                        string query = "select Email, Codigo from TBAluno where Email = @Email and Codigo = @Codigo";
                        var aluno = conexaoBD.QueryFirstOrDefault<Aluno>(query, new { Email = email, Codigo = codigo });
                        return aluno;
                    }
                }
                catch (InvalidOperationException ex)
                {
                    throw new InvalidOperationException(nameof(ex.Message));
                }
                catch (ConfigurationErrorsException ex)
                {
                    throw new ConfigurationErrorsException(nameof(ex.Message));
                }
                catch (Exception ex)
                {
                    throw new Exception(nameof(ex.Message));
                }
            }
            else
            {
                this.Dispose(true);
                throw new Exception(MessageAluno.MessageValidationEmailIsNullOrEmpty);
            }
        }

        public Aluno PersistencePesquisarPorNome(string nome, string email)
        {
            if (!string.IsNullOrEmpty(nome) && !string.IsNullOrEmpty(email))
            {
                try
                {
                    using (SqlConnection conexaoBD = new SqlConnection(ConfigurationManager.ConnectionStrings["dbBibliotecaAcademica"].ConnectionString))
                    {
                        conexaoBD.Open();
                        string query = "select Nome, Email from TBAluno where Nome = @Nome and Email = @Email";
                        var aluno = conexaoBD.QueryFirstOrDefault<Aluno>(query, new { Nome = nome, Email = email });
                        return aluno;
                    }
                }
                catch (InvalidOperationException ex)
                {
                    throw new InvalidOperationException(nameof(ex.Message));
                }
                catch (ConfigurationErrorsException ex)
                {
                    throw new ConfigurationErrorsException(nameof(ex.Message));
                }
                catch (Exception ex)
                {
                    throw new Exception(nameof(ex.Message));
                }
            }
            else
            {
                this.Dispose(true);
                throw new Exception(MessageAluno.MessageValidationEmailIsNullOrEmpty);
            }
        }

        public Aluno PersistencePesquisarPorSobrenome(string sobrenome, string email)
        {
            if (!string.IsNullOrEmpty(sobrenome) && !string.IsNullOrEmpty(email))
            {
                try
                {
                    using (SqlConnection conexaoBD = new SqlConnection(ConfigurationManager.ConnectionStrings["dbBibliotecaAcademica"].ConnectionString))
                    {
                        conexaoBD.Open();
                        string query = "select Sobrenome, Email from TBAluno where Nome = @Sobrenome and Email = @Email";
                        var aluno = conexaoBD.QueryFirstOrDefault<Aluno>(query, new { Sobrenome = sobrenome, Email = email });
                        return aluno;
                    }
                }
                catch (InvalidOperationException ex)
                {
                    throw new InvalidOperationException(nameof(ex.Message));
                }
                catch (ConfigurationErrorsException ex)
                {
                    throw new ConfigurationErrorsException(nameof(ex.Message));
                }
                catch (Exception ex)
                {
                    throw new Exception(nameof(ex.Message));
                }
            }
            else
            {
                this.Dispose(true);
                throw new Exception(MessageAluno.MessageValidationEmailIsNullOrEmpty);
            }
        }

        #endregion        
    }
}