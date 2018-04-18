using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
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
                Component.For<SocialManagerLibrary.IMessagesSearch>()
                                .ImplementedBy<SocialManagerLibrary.Providers.TwitterProvider>()
                                .LifestyleTransient());
        }
    }

}