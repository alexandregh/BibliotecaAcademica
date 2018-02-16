[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(BibliotecaAcademica.Web.App_Start.NinjectWebCommon), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethodAttribute(typeof(BibliotecaAcademica.Web.App_Start.NinjectWebCommon), "Stop")]

namespace BibliotecaAcademica.Web.App_Start
{
    using System;
    using System.Web;

    using Ninject;
    using Ninject.Web.Common;

    using BibliotecaAcademica.App.AppServices.AppServicesBases;
    using BibliotecaAcademica.App.AppServices.AppServicesEntity.AppServicesAlunos;
    using BibliotecaAcademica.App.AppServices.AppServicesEntity.AppServicesAutores;
    using BibliotecaAcademica.App.AppServices.AppServicesEntity.AppServicesEditoras;
    using BibliotecaAcademica.App.AppServices.AppServicesEntity.AppServicesExemplares;
    using BibliotecaAcademica.App.AppServices.AppServicesEntity.AppServicesFuncionarios;
    using BibliotecaAcademica.App.AppServices.AppServicesEntity.AppServicesLivros;
    using BibliotecaAcademica.App.AppServices.AppServicesEntity.AppServicesProfessores;
    using BibliotecaAcademica.Domain.DomainContextBasic.DomainServices.DomainServicesBases;
    using BibliotecaAcademica.Domain.DomainContextBasic.DomainServices.DomainServicesEntity.DomainServicesAlunos;
    using BibliotecaAcademica.Domain.DomainContextBasic.DomainServices.DomainServicesEntity.DomainServicesAutores;
    using BibliotecaAcademica.Domain.DomainContextBasic.DomainServices.DomainServicesEntity.DomainServicesEditoras;
    using BibliotecaAcademica.Domain.DomainContextBasic.DomainServices.DomainServicesEntity.DomainServicesExemplares;
    using BibliotecaAcademica.Domain.DomainContextBasic.DomainServices.DomainServicesEntity.DomainServicesFuncionarios;
    using BibliotecaAcademica.Domain.DomainContextBasic.DomainServices.DomainServicesEntity.DomainServicesLivros;
    using BibliotecaAcademica.Domain.DomainContextBasic.DomainServices.DomainServicesEntity.DomainServicesProfessores;
    using BibliotecaAcademica.Domain.DomainContextBasic.IContracts.IContractsAppServices.IContractsAppBases;
    using BibliotecaAcademica.Domain.DomainContextBasic.IContracts.IContractsAppServices.IContractsAppEntity.IContractsAppAlunos;
    using BibliotecaAcademica.Domain.DomainContextBasic.IContracts.IContractsAppServices.IContractsAppEntity.IContractsAppAutores;
    using BibliotecaAcademica.Domain.DomainContextBasic.IContracts.IContractsAppServices.IContractsAppEntity.IContractsAppEditoras;
    using BibliotecaAcademica.Domain.DomainContextBasic.IContracts.IContractsAppServices.IContractsAppEntity.IContractsAppExemplares;
    using BibliotecaAcademica.Domain.DomainContextBasic.IContracts.IContractsAppServices.IContractsAppEntity.IContractsAppFuncionarios;
    using BibliotecaAcademica.Domain.DomainContextBasic.IContracts.IContractsAppServices.IContractsAppEntity.IContractsAppLivros;
    using BibliotecaAcademica.Domain.DomainContextBasic.IContracts.IContractsAppServices.IContractsAppEntity.IContractsAppProfessores;
    using BibliotecaAcademica.Domain.DomainContextBasic.IContracts.IContractsDomainServices.IContractsDomainServicesBases;
    using BibliotecaAcademica.Domain.DomainContextBasic.IContracts.IContractsDomainServices.IContractsDomainServicesEntity.IContractsDomainServicesAlunos;
    using BibliotecaAcademica.Domain.DomainContextBasic.IContracts.IContractsDomainServices.IContractsDomainServicesEntity.IContractsDomainServicesAutores;
    using BibliotecaAcademica.Domain.DomainContextBasic.IContracts.IContractsDomainServices.IContractsDomainServicesEntity.IContractsDomainServicesEditoras;
    using BibliotecaAcademica.Domain.DomainContextBasic.IContracts.IContractsDomainServices.IContractsDomainServicesEntity.IContractsDomainServicesExemplares;
    using BibliotecaAcademica.Domain.DomainContextBasic.IContracts.IContractsDomainServices.IContractsDomainServicesEntity.IContractsDomainServicesFuncionarios;
    using BibliotecaAcademica.Domain.DomainContextBasic.IContracts.IContractsDomainServices.IContractsDomainServicesEntity.IContractsDomainServicesLivros;
    using BibliotecaAcademica.Domain.DomainContextBasic.IContracts.IContractsDomainServices.IContractsDomainServicesEntity.IContractsDomainServicesProfessores;
    using BibliotecaAcademica.Domain.DomainContextBasic.IContracts.IContractsInfraEstructure.IContractsSGBDServices.IContractsSGBDBases;
    using BibliotecaAcademica.Domain.DomainContextBasic.IContracts.IContractsInfraEstructure.IContractsSGBDServices.IContractsSGBDEntity.IContractsSGBDAlunos;
    using BibliotecaAcademica.Domain.DomainContextBasic.IContracts.IContractsInfraEstructure.IContractsSGBDServices.IContractsSGBDEntity.IContractsSGBDAutores;
    using BibliotecaAcademica.Domain.DomainContextBasic.IContracts.IContractsInfraEstructure.IContractsSGBDServices.IContractsSGBDEntity.IContractsSGBDEditoras;
    using BibliotecaAcademica.Domain.DomainContextBasic.IContracts.IContractsInfraEstructure.IContractsSGBDServices.IContractsSGBDEntity.IContractsSGBDExemplares;
    using BibliotecaAcademica.Domain.DomainContextBasic.IContracts.IContractsInfraEstructure.IContractsSGBDServices.IContractsSGBDEntity.IContractsSGBDFuncionarios;
    using BibliotecaAcademica.Domain.DomainContextBasic.IContracts.IContractsInfraEstructure.IContractsSGBDServices.IContractsSGBDEntity.IContractsSGBDLivros;
    using BibliotecaAcademica.Domain.DomainContextBasic.IContracts.IContractsInfraEstructure.IContractsSGBDServices.IContractsSGBDEntity.IContractsSGBDProfessores;
    using BibliotecaAcademica.SGBD.Repository.RepositoryBases;
    using BibliotecaAcademica.SGBD.Repository.RepositoryEntity.RepositoryAlunos;
    using Microsoft.Web.Infrastructure.DynamicModuleHelper;
    using BibliotecaAcademica.SGBD.Repository.RepositoryEntity.RepositoryAutores;
    using BibliotecaAcademica.SGBD.Repository.RepositoryEntity.RepositoryEditoras;
    using BibliotecaAcademica.SGBD.Repository.RepositoryEntity.RepositoryExemplares;
    using BibliotecaAcademica.SGBD.Repository.RepositoryEntity.RepositoryFuncionarios;
    using BibliotecaAcademica.SGBD.Repository.RepositoryEntity.RepositoryLivros;
    using BibliotecaAcademica.SGBD.Repository.RepositoryEntity.RepositoryProfessores;

    public static class NinjectWebCommon
    {
        private static readonly Bootstrapper bootstrapper = new Bootstrapper();

        /// <summary>
        /// Starts the application
        /// </summary>
        public static void Start()
        {
            DynamicModuleUtility.RegisterModule(typeof(OnePerRequestHttpModule));
            DynamicModuleUtility.RegisterModule(typeof(NinjectHttpModule));
            bootstrapper.Initialize(CreateKernel);
        }

        /// <summary>
        /// Stops the application.
        /// </summary>
        public static void Stop()
        {
            bootstrapper.ShutDown();
        }

        /// <summary>
        /// Creates the kernel that will manage your application.
        /// </summary>
        /// <returns>The created kernel.</returns>
        private static IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            try
            {
                kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
                kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();

                RegisterServices(kernel);
                return kernel;
            }
            catch
            {
                kernel.Dispose();
                throw;
            }
        }

        /// <summary>
        /// Load your modules or register your services here!
        /// </summary>
        /// <param name="kernel">The kernel.</param>
        private static void RegisterServices(IKernel kernel)
        {
            //configurar a injeção de dependencia...
            // Configuração Camada Aplicação...
            kernel.Bind(typeof(IContractsAppBase<>)).To(typeof(AppServicesBase<>));
            kernel.Bind<IContractsAppAluno>().To<AppServicesAluno>();
            kernel.Bind<IContractsAppAutor>().To<AppServicesAutor>();
            kernel.Bind<IContractsAppEditora>().To<AppServicesEditora>();
            kernel.Bind<IContractsAppExemplar>().To<AppServicesExemplar>();
            kernel.Bind<IContractsAppFuncionario>().To<AppServicesFuncionario>();
            kernel.Bind<IContractsAppLivro>().To<AppServicesLivro>();
            kernel.Bind<IContractsAppProfessor>().To<AppServicesProfessor>();

            // Configuração Camada Domínio...
            kernel.Bind(typeof(IContractsDomainServicesBase<>)).To(typeof(DomainServicesBase<>));
            kernel.Bind<IContractsDomainServicesAluno>().To<DomainServicesAluno>();
            kernel.Bind<IContractsDomainServicesAutor>().To<DomainServicesAutor>();
            kernel.Bind<IContractsDomainServicesEditora>().To<DomainServicesEditora>();
            kernel.Bind<IContractsDomainServicesExemplar>().To<DomainServicesExemplar>();
            kernel.Bind<IContractsDomainServicesFuncionario>().To<DomainServicesFuncionario>();
            kernel.Bind<IContractsDomainServicesLivro>().To<DomainServicesLivro>();
            kernel.Bind<IContractsDomainServicesProfessor>().To<DomainServicesProfessor>();

            // Configuração Camada Persistência...
            kernel.Bind(typeof(IContractsSGBDBase<>)).To(typeof(RepositoryBase<>));
            kernel.Bind<IContractsSGBDAluno>().To<RepositoryAluno>();
            kernel.Bind<IContractsSGBDAutor>().To<RepositoryAutor>();
            kernel.Bind<IContractsSGBDEditora>().To<RepositoryEditora>();
            kernel.Bind<IContractsSGBDExemplar>().To<RepositoryExemplar>();
            kernel.Bind<IContractsSGBDFuncionario>().To<RepositoryFuncionario>();
            kernel.Bind<IContractsSGBDLivro>().To<RepositoryLivro>();
            kernel.Bind<IContractsSGBDProfessor>().To<RepositoryProfessor>();
        }
    }
}