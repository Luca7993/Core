namespace Demo.Web.Windsor
{
    using Castle.MicroKernel;
    using Castle.MicroKernel.Registration;
    using Castle.Windsor;

    public class RegisterServices : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Component.For<IDatabase>().ImplementedBy<InMemoryDatabasae>().LifeStyle.PerWebRequest)
                     .Register(Component.For(typeof(IRepository<>)).ImplementedBy(typeof(Repository<>)).LifeStyle.PerWebRequest);
        }
    }
}