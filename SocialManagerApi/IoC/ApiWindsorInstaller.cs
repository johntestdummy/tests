using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using SocialManagerApi.Controllers;
using SocialManagerLibrary.Interfaces;
using SocialManagerLibrary.Providers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SocialManagerApi.IoC
{
    public class ApiWindsorInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(
                Classes.FromThisAssembly().BasedOn<TwitterController>().LifestylePerWebRequest(),
                Component.For<IMessagesSearch>()
                    .ImplementedBy<TwitterMessagesProvider>().LifestylePerWebRequest(),
                Component.For<IConfigurationProvider>()
                    .ImplementedBy<ConfigurationFileProvider>().LifestylePerWebRequest(),
                Component.For<IApiConnectionHandler>()
                    .ImplementedBy<TwitterApiConnectionHandler>().LifestylePerWebRequest()
            );
        }
    }

}