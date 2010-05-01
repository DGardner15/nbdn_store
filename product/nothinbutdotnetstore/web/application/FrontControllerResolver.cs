using System;
using nothinbutdotnetstore.infrastructure.containers;
using nothinbutdotnetstore.web.application;
using nothinbutdotnetstore.web.core;

namespace nothinbutdotnetstore.tests.web
{
    public class FrontControllerResolver : ContainerResolver
    {

        FrontController front_controller =
            new DefaultFrontController(
                new DefaultCommandRegistry(
                    new RequestCommand[]
                    {
                        new DefaultRequestCommand(x=>true, new ViewMainDepartments())

                    }));


        public object resolve()
        {
            return front_controller;
        }
    }
}
