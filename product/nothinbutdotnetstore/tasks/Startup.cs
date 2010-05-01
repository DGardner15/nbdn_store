using System;
using System.Collections.Generic;
using nothinbutdotnetstore.infrastructure.containers;
using nothinbutdotnetstore.infrastructure.containers.custom;
using nothinbutdotnetstore.tests.web;
using nothinbutdotnetstore.web.application;
using nothinbutdotnetstore.web.core;

namespace nothinbutdotnetstore.tasks
{
    public class Startup
    {
        public static void run()
        {
            Container.container_resolver = () => new CustomContainerFramework(
                                                     new Dictionary<Type, ContainerResolver>
                                                     {
                                                         {typeof (FrontController), new FrontControllerResolver()},
                                                         {typeof (RequestFactory), new RequestFactoryResolver()}
                                                     }
                                                     );
        }
    }
}