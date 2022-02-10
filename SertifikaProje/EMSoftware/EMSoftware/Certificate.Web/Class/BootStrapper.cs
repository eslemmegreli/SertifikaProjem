using Autofac;
using Autofac.Integration.Mvc;
using Certificate.CoreCore.Infrastructure;
using Certificate.Web;
using CertificateCore.Repository;
using System.Web.Mvc;

namespace Certificate.Web.Class
{
    public class BootStrapper
    {
        public static void RunConfig()
        {
            BuildAutoFac();
        }
        private static void BuildAutoFac()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<CertificateRepository>().As<ICertificateRepository>();

            builder.RegisterControllers(typeof(MvcApplication).Assembly);
            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}